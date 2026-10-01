using ClienteAgentesGraphQL.Model;
using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>Caso de uso: ADICIONAR un agente de navegación.</summary>
    public partial class GUIAdicionarNavegacion : Form
    {
        public GUIAdicionarNavegacion()
        {
            InitializeComponent();
            Limpiar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            AgenteNavegacionInput input = LeerFormulario();
            if (input == null) return; // algún dato no es válido (ya se mostró el mensaje)

            try
            {
                btnGuardar.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                AgenteNavegacion creado = await GraphQLService.AdicionarAsync(input);
                UtilidadesGUI.MostrarInformacion(this,
                    $"El agente \"{creado.Nombre}\" (ID {creado.IdAgente}) se adicionó correctamente.\n" +
                    $"Rendimiento calculado: {UtilidadesGUI.FormatearNumero(creado.Rendimiento)}", "Operación exitosa");
                Limpiar();
            }
            catch (Exception ex)
            {
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                btnGuardar.Enabled = true;
                UtilidadesGUI.Ocupado(this, false);
            }
        }

        /// <summary>Lee y valida lo que escribió el usuario. Retorna null si algo no es válido.</summary>
        private AgenteNavegacionInput LeerFormulario()
        {
            if (!UtilidadesGUI.LeerEntero(this, txtIdAgente, "El ID del agente", 1, out int id)) return null;
            if (!UtilidadesGUI.LeerTexto(this, txtNombre, "El nombre", out string nombre)) return null;
            if (cmbEstadoOperativo.SelectedItem == null)
            {
                UtilidadesGUI.MostrarAdvertencia(this, "Seleccione el estado operativo.");
                cmbEstadoOperativo.Focus();
                return null;
            }
            if (!UtilidadesGUI.LeerTexto(this, txtOrigen, "El origen", out string origen)) return null;
            if (!UtilidadesGUI.LeerTexto(this, txtDestino, "El destino", out string destino)) return null;
            if (!UtilidadesGUI.LeerDecimal(this, txtNivelAutonomia, "El nivel de autonomía", 0, 100, out double autonomia)) return null;
            if (!UtilidadesGUI.LeerDecimal(this, txtNivelConfianza, "El nivel de confianza", 0, 100, out double confianza)) return null;
            if (!UtilidadesGUI.LeerDecimal(this, txtPrecisionGPS, "La precisión GPS", 0, 100, out double precision)) return null;

            return new AgenteNavegacionInput
            {
                IdAgente = id,
                Nombre = nombre,
                NivelAutonomia = autonomia,
                EstadoOperativo = cmbEstadoOperativo.SelectedItem.ToString(),
                NivelConfianza = confianza,
                Origen = origen,
                Destino = destino,
                PrecisionGPS = precision,
                FechaUltimaCalibracion = AgenteNavegacionInput.FormatearFecha(dtpFechaCalibracion.Value)
            };
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        private void Limpiar()
        {
            UtilidadesGUI.LimpiarCampos(txtIdAgente, txtNombre, txtOrigen, txtDestino,
                txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS);
            cmbEstadoOperativo.SelectedIndex = 0;
            dtpFechaCalibracion.Value = DateTime.Now;
            txtIdAgente.Focus();
        }
    }
}
