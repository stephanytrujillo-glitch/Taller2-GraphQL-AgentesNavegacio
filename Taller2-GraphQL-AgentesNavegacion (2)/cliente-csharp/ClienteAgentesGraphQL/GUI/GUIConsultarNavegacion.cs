using ClienteAgentesGraphQL.Model;
using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>Caso de uso: CONSULTAR un solo agente a partir del ID escrito por el usuario.</summary>
    public partial class GUIConsultarNavegacion : Form
    {
        public GUIConsultarNavegacion()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!UtilidadesGUI.LeerEntero(this, txtBuscarId, "El ID a buscar", 1, out int id)) return;
            try
            {
                btnBuscar.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                AgenteNavegacion agente = await GraphQLService.BuscarPorIdAsync(id);

                if (agente == null)
                {
                    Limpiar();
                    UtilidadesGUI.MostrarInformacion(this, $"No existe un agente de navegación con ID {id}.", "Consulta");
                    return;
                }
                UtilidadesGUI.MostrarAgente(agente, txtIdAgente, txtNombre, txtEstadoOperativo, txtOrigen, txtDestino,
                    txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS, txtFechaCalibracion, txtRendimiento);
            }
            catch (Exception ex)
            {
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                btnBuscar.Enabled = true;
                UtilidadesGUI.Ocupado(this, false);
            }
        }

        private void Limpiar()
        {
            UtilidadesGUI.LimpiarCampos(txtIdAgente, txtNombre, txtEstadoOperativo, txtOrigen, txtDestino,
                txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS, txtFechaCalibracion, txtRendimiento);
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
