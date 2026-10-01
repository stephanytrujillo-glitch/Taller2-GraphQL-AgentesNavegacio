using ClienteAgentesGraphQL.Model;
using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>
    /// Caso de uso: ELIMINAR un agente.
    /// Primero se busca, se muestra TODA su información y luego se confirma la eliminación.
    /// </summary>
    public partial class GUIEliminarNavegacion : Form
    {
        private AgenteNavegacion agenteEncontrado;

        public GUIEliminarNavegacion()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
            txtBuscarId.TextChanged += (s, e) => ReiniciarSeleccion();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!UtilidadesGUI.LeerEntero(this, txtBuscarId, "El ID a buscar", 1, out int id)) return;
            try
            {
                btnBuscar.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                agenteEncontrado = await GraphQLService.BuscarPorIdAsync(id);

                if (agenteEncontrado == null)
                {
                    ReiniciarSeleccion();
                    UtilidadesGUI.MostrarInformacion(this, $"No existe un agente de navegación con ID {id}.", "Consulta");
                    return;
                }
                UtilidadesGUI.MostrarAgente(agenteEncontrado, txtIdAgente, txtNombre, txtEstadoOperativo, txtOrigen,
                    txtDestino, txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS, txtFechaCalibracion, txtRendimiento);
                btnEliminar.Enabled = true;
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (agenteEncontrado == null) return;

            DialogResult confirmacion = MessageBox.Show(this,
                $"¿Está seguro de eliminar el agente \"{agenteEncontrado.Nombre}\" (ID {agenteEncontrado.IdAgente})?\n\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirmacion != DialogResult.Yes) return;

            try
            {
                btnEliminar.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                AgenteNavegacion eliminado = await GraphQLService.EliminarAsync(agenteEncontrado.IdAgente);
                UtilidadesGUI.MostrarInformacion(this,
                    $"El agente \"{eliminado.Nombre}\" (ID {eliminado.IdAgente}) fue eliminado.", "Operación exitosa");
                txtBuscarId.Clear(); // esto también limpia lo mostrado
            }
            catch (Exception ex)
            {
                btnEliminar.Enabled = true;
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                UtilidadesGUI.Ocupado(this, false);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        /// <summary>Si cambia el ID escrito se limpia lo mostrado para no eliminar un agente equivocado.</summary>
        private void ReiniciarSeleccion()
        {
            agenteEncontrado = null;
            btnEliminar.Enabled = false;
            UtilidadesGUI.LimpiarCampos(txtIdAgente, txtNombre, txtEstadoOperativo, txtOrigen, txtDestino,
                txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS, txtFechaCalibracion, txtRendimiento);
        }
    }
}
