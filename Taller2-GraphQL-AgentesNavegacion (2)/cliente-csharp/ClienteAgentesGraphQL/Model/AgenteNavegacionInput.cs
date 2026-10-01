using System.Globalization;

namespace ClienteAgentesGraphQL.Model
{
    /// <summary>
    /// Datos que se envían al servidor en las mutaciones de crear y actualizar.
    /// Corresponde al tipo GraphQL "AgenteNavegacionInput".
    /// </summary>
    public class AgenteNavegacionInput
    {
        public int IdAgente { get; set; }
        public string Nombre { get; set; } = "";
        public double NivelAutonomia { get; set; }
        public string EstadoOperativo { get; set; } = "";
        public double NivelConfianza { get; set; }
        public string Origen { get; set; } = "";
        public string Destino { get; set; } = "";
        public double PrecisionGPS { get; set; }
        public string FechaUltimaCalibracion { get; set; } = "";

        /// <summary>Convierte una fecha al formato que espera el servidor.</summary>
        public static string FormatearFecha(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour, fecha.Minute, 0)
                .ToString(AgenteNavegacion.FormatoFechaServidor, CultureInfo.InvariantCulture);
        }
    }
}
