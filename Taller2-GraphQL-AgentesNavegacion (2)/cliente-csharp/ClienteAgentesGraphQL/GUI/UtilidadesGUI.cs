using System.Globalization;
using ClienteAgentesGraphQL.Model;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>
    /// Funciones de apoyo compartidas por las ventanas (solo tareas de interfaz gráfica:
    /// mensajes, lectura/validación de lo que escribe el usuario y presentación de datos).
    /// </summary>
    internal static class UtilidadesGUI
    {
        // ============================== MENSAJES ==============================

        public static void MostrarError(IWin32Window ventana, Exception ex)
        {
            MessageBox.Show(ventana, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarInformacion(IWin32Window ventana, string mensaje, string titulo = "Información")
        {
            MessageBox.Show(ventana, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarAdvertencia(IWin32Window ventana, string mensaje)
        {
            MessageBox.Show(ventana, mensaje, "Revise los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ================== LECTURA DE DATOS ESCRITOS POR EL USUARIO ==================

        /// <summary>
        /// Lee un número entero escrito en una caja de texto.
        /// Si no es válido muestra un mensaje, selecciona la caja y retorna false.
        /// </summary>
        public static bool LeerEntero(IWin32Window ventana, TextBox caja, string campo, int minimo, out int valor)
        {
            if (!int.TryParse(caja.Text.Trim(), out valor) || valor < minimo)
            {
                MostrarAdvertencia(ventana, $"{campo} debe ser un número entero mayor o igual a {minimo}.");
                Enfocar(caja);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Lee un número decimal escrito en una caja de texto (acepta punto o coma como separador).
        /// Si no es válido o está fuera del rango muestra un mensaje, selecciona la caja y retorna false.
        /// </summary>
        public static bool LeerDecimal(IWin32Window ventana, TextBox caja, string campo, double minimo, double maximo,
                                       out double valor)
        {
            string texto = caja.Text.Trim().Replace(',', '.');
            if (!double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out valor)
                || valor < minimo || valor > maximo)
            {
                MostrarAdvertencia(ventana,
                    $"{campo} debe ser un número entre {minimo} y {maximo}.\nPuede usar punto o coma para los decimales (ej. 85.5).");
                Enfocar(caja);
                return false;
            }
            return true;
        }

        /// <summary>Verifica que una caja de texto no esté vacía.</summary>
        public static bool LeerTexto(IWin32Window ventana, TextBox caja, string campo, out string valor)
        {
            valor = caja.Text.Trim();
            if (valor.Length == 0)
            {
                MostrarAdvertencia(ventana, $"{campo} es obligatorio.");
                Enfocar(caja);
                return false;
            }
            return true;
        }

        private static void Enfocar(TextBox caja)
        {
            caja.Focus();
            caja.SelectAll();
        }

        // ============================ PRESENTACIÓN ============================

        /// <summary>Muestra un número sin decimales innecesarios, con punto decimal (ej. 85.5).</summary>
        public static string FormatearNumero(double valor) => valor.ToString("0.##", CultureInfo.InvariantCulture);

        /// <summary>Muestra TODOS los atributos de un agente en campos de solo lectura.</summary>
        public static void MostrarAgente(AgenteNavegacion a, TextBox txtIdAgente, TextBox txtNombre,
            TextBox txtEstadoOperativo, TextBox txtOrigen, TextBox txtDestino, TextBox txtNivelAutonomia,
            TextBox txtNivelConfianza, TextBox txtPrecisionGPS, TextBox txtFechaCalibracion, TextBox txtRendimiento)
        {
            txtIdAgente.Text = a.IdAgente.ToString();
            txtNombre.Text = a.Nombre;
            txtEstadoOperativo.Text = a.EstadoOperativo;
            txtOrigen.Text = a.Origen;
            txtDestino.Text = a.Destino;
            txtNivelAutonomia.Text = FormatearNumero(a.NivelAutonomia);
            txtNivelConfianza.Text = FormatearNumero(a.NivelConfianza);
            txtPrecisionGPS.Text = FormatearNumero(a.PrecisionGPS);
            txtFechaCalibracion.Text = a.FechaLegible;
            txtRendimiento.Text = FormatearNumero(a.Rendimiento);
        }

        public static void LimpiarCampos(params TextBox[] campos)
        {
            foreach (TextBox campo in campos) campo.Clear();
        }

        /// <summary>Asigna una fecha al DateTimePicker respetando sus límites.</summary>
        public static void AsignarFecha(DateTimePicker selector, DateTime fecha)
        {
            if (fecha < selector.MinDate) fecha = selector.MinDate;
            if (fecha > selector.MaxDate) fecha = selector.MaxDate;
            selector.Value = fecha;
        }

        /// <summary>Muestra el cursor de espera mientras se consulta el servidor.</summary>
        public static void Ocupado(Form ventana, bool ocupado)
        {
            ventana.UseWaitCursor = ocupado;
            ventana.Cursor = ocupado ? Cursors.WaitCursor : Cursors.Default;
        }
    }
}
