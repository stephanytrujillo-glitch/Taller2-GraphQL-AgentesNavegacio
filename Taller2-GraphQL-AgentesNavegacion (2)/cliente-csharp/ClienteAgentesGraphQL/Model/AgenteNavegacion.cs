using System.Globalization;

namespace ClienteAgentesGraphQL.Model
{
    /// <summary>
    /// Representación en el cliente del tipo GraphQL "AgenteNavegacion".
    /// </summary>
    public class AgenteNavegacion
    {
        /// <summary>Formato en el que el servidor envía y recibe las fechas (LocalDateTime ISO).</summary>
        public const string FormatoFechaServidor = "yyyy-MM-dd'T'HH:mm:ss";

        public int IdAgente { get; set; }
        public string Nombre { get; set; } = "";
        public double NivelAutonomia { get; set; }
        public string EstadoOperativo { get; set; } = "";
        public double NivelConfianza { get; set; }
        public string Origen { get; set; } = "";
        public string Destino { get; set; } = "";
        public double PrecisionGPS { get; set; }
        public string FechaUltimaCalibracion { get; set; } = "";
        /// <summary>Calculado en el servidor: (precisionGPS + nivelConfianza) / 2.</summary>
        public double Rendimiento { get; set; }

        public DateTime ObtenerFechaCalibracion()
        {
            return DateTime.TryParseExact(FechaUltimaCalibracion, FormatoFechaServidor, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime fecha) ? fecha : DateTime.Now;
        }

        public string FechaLegible => ObtenerFechaCalibracion().ToString("yyyy-MM-dd HH:mm");

        public override string ToString() => $"{IdAgente} - {Nombre}";
    }
}
