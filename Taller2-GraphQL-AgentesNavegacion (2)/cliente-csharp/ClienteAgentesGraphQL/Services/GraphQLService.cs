using System.Net.Http;
using System.Text;
using System.Text.Json;
using ClienteAgentesGraphQL.Model;

namespace ClienteAgentesGraphQL.Services
{
    /// <summary>
    /// Se encarga de TODA la comunicación con el servidor GraphQL (Java / Spring Boot).
    /// Envía las queries y mutations por HTTP POST en formato JSON: { "query": ..., "variables": ... }.
    /// </summary>
    public static class GraphQLService
    {
        private const string EndpointPorDefecto = "http://localhost:8081/graphql";

        /// <summary>Campos del agente que se solicitan en cada operación.</summary>
        private const string Campos =
            "idAgente nombre nivelAutonomia estadoOperativo nivelConfianza origen destino precisionGPS fechaUltimaCalibracion rendimiento";

        private static readonly HttpClient Http = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        private static readonly JsonSerializerOptions OpcionesJson = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// URL del servidor. Se lee del archivo "servidor.txt" que está junto al .exe;
        /// así se puede apuntar a otro equipo de la red sin recompilar (ej. http://192.168.1.20:8081/graphql).
        /// </summary>
        public static string Endpoint { get; } = LeerEndpoint();

        private static string LeerEndpoint()
        {
            try
            {
                string ruta = Path.Combine(AppContext.BaseDirectory, "servidor.txt");
                if (File.Exists(ruta))
                {
                    string url = File.ReadAllText(ruta).Trim();
                    if (!string.IsNullOrWhiteSpace(url)) return url;
                }
            }
            catch (IOException) { /* si no se puede leer se usa el valor por defecto */ }
            return EndpointPorDefecto;
        }

        // =============================== QUERIES ===============================

        /// <summary>Listado variante 1: todos los agentes.</summary>
        public static Task<List<AgenteNavegacion>> ListarTodosAsync()
        {
            string query = $"query {{ agentesNavegacion {{ {Campos} }} }}";
            return EjecutarAsync<List<AgenteNavegacion>>(query, null, "agentesNavegacion");
        }

        /// <summary>Listado variante 2: filtrado en el SERVIDOR por nombre y/o estado operativo.</summary>
        public static Task<List<AgenteNavegacion>> ListarPorFiltroAsync(string nombre, string estadoOperativo)
        {
            string query = $"query ($nombre: String, $estadoOperativo: String) {{ agentesNavegacionPorFiltro(nombre: $nombre, estadoOperativo: $estadoOperativo) {{ {Campos} }} }}";
            return EjecutarAsync<List<AgenteNavegacion>>(query, new { nombre, estadoOperativo }, "agentesNavegacionPorFiltro");
        }

        /// <summary>Consulta un solo agente. Retorna null si no existe.</summary>
        public static Task<AgenteNavegacion> BuscarPorIdAsync(int idAgente)
        {
            string query = $"query ($idAgente: Int!) {{ agenteNavegacionPorId(idAgente: $idAgente) {{ {Campos} }} }}";
            return EjecutarAsync<AgenteNavegacion>(query, new { idAgente }, "agenteNavegacionPorId");
        }

        // ============================== MUTATIONS ==============================

        public static Task<AgenteNavegacion> AdicionarAsync(AgenteNavegacionInput input)
        {
            string mutation = $"mutation ($input: AgenteNavegacionInput!) {{ crearAgenteNavegacion(input: $input) {{ {Campos} }} }}";
            return EjecutarAsync<AgenteNavegacion>(mutation, new { input }, "crearAgenteNavegacion");
        }

        public static Task<AgenteNavegacion> ActualizarAsync(AgenteNavegacionInput input)
        {
            string mutation = $"mutation ($input: AgenteNavegacionInput!) {{ actualizarAgenteNavegacion(input: $input) {{ {Campos} }} }}";
            return EjecutarAsync<AgenteNavegacion>(mutation, new { input }, "actualizarAgenteNavegacion");
        }

        public static Task<AgenteNavegacion> EliminarAsync(int idAgente)
        {
            string mutation = $"mutation ($idAgente: Int!) {{ eliminarAgenteNavegacion(idAgente: $idAgente) {{ {Campos} }} }}";
            return EjecutarAsync<AgenteNavegacion>(mutation, new { idAgente }, "eliminarAgenteNavegacion");
        }

        /// <summary>Verifica que el servidor responda.</summary>
        public static async Task ProbarConexionAsync()
        {
            await EjecutarAsync<string>("query { __typename }", null, "__typename");
        }

        // ============================ NÚCLEO HTTP ============================

        private static async Task<T> EjecutarAsync<T>(string query, object variables, string campoRespuesta)
        {
            string cuerpo = JsonSerializer.Serialize(new { query, variables }, OpcionesJson);
            HttpResponseMessage respuesta;
            try
            {
                using var contenido = new StringContent(cuerpo, Encoding.UTF8, "application/json");
                respuesta = await Http.PostAsync(Endpoint, contenido);
            }
            catch (HttpRequestException)
            {
                throw new InvalidOperationException(
                    $"No se pudo conectar con el servidor GraphQL en:\n{Endpoint}\n\nVerifique que el servidor Java esté en ejecución.");
            }
            catch (TaskCanceledException)
            {
                throw new InvalidOperationException("El servidor tardó demasiado en responder. Intente de nuevo.");
            }

            string json = await respuesta.Content.ReadAsStringAsync();
            JsonDocument documento;
            try
            {
                documento = JsonDocument.Parse(json);
            }
            catch (JsonException)
            {
                throw new InvalidOperationException(
                    $"Respuesta inesperada del servidor (HTTP {(int)respuesta.StatusCode}). ¿La URL {Endpoint} es correcta?");
            }

            using (documento)
            {
                JsonElement raiz = documento.RootElement;

                // Errores reportados por GraphQL (validaciones del servidor, agente no encontrado, etc.)
                if (raiz.TryGetProperty("errors", out JsonElement errores) && errores.ValueKind == JsonValueKind.Array
                    && errores.GetArrayLength() > 0)
                {
                    var mensajes = errores.EnumerateArray()
                        .Select(e => e.TryGetProperty("message", out JsonElement m) ? m.GetString() : "Error desconocido");
                    throw new InvalidOperationException(string.Join(Environment.NewLine, mensajes));
                }

                if (!respuesta.IsSuccessStatusCode)
                    throw new InvalidOperationException($"El servidor respondió con error HTTP {(int)respuesta.StatusCode}.");

                if (!raiz.TryGetProperty("data", out JsonElement data) || data.ValueKind != JsonValueKind.Object
                    || !data.TryGetProperty(campoRespuesta, out JsonElement nodo) || nodo.ValueKind == JsonValueKind.Null)
                {
                    return default;
                }

                return nodo.Deserialize<T>(OpcionesJson);
            }
        }
    }
}
