using ClienteAgentesGraphQL.Model;
using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>
    /// Caso de uso: LISTAR agentes en una grilla.
    /// Variante 1: todos. Variante 2: filtrados en el SERVIDOR por nombre y/o estado operativo.
    /// </summary>
    public partial class GUIListarNavegacion : Form
    {
        public GUIListarNavegacion()
        {
            InitializeComponent();
            cmbFiltroEstado.SelectedIndex = 0; // "Todos"
        }

        private async void GUIListarNavegacion_Load(object sender, EventArgs e)
        {
            await CargarAsync(GraphQLService.ListarTodosAsync());
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nombre = string.IsNullOrWhiteSpace(txtFiltroNombre.Text) ? null : txtFiltroNombre.Text.Trim();
            string estado = cmbFiltroEstado.SelectedIndex <= 0 ? null : cmbFiltroEstado.SelectedItem.ToString();
            await CargarAsync(GraphQLService.ListarPorFiltroAsync(nombre, estado));
        }

        private async void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Clear();
            cmbFiltroEstado.SelectedIndex = 0;
            await CargarAsync(GraphQLService.ListarTodosAsync());
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        private async Task CargarAsync(Task<List<AgenteNavegacion>> consulta)
        {
            try
            {
                btnFiltrar.Enabled = btnMostrarTodos.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                List<AgenteNavegacion> agentes = await consulta ?? new List<AgenteNavegacion>();

                dgvAgentes.Rows.Clear();
                foreach (AgenteNavegacion a in agentes)
                {
                    dgvAgentes.Rows.Add(a.IdAgente, a.Nombre, a.EstadoOperativo, UtilidadesGUI.FormatearNumero(a.NivelAutonomia),
                        UtilidadesGUI.FormatearNumero(a.NivelConfianza), a.Origen, a.Destino, UtilidadesGUI.FormatearNumero(a.PrecisionGPS),
                        a.FechaLegible, UtilidadesGUI.FormatearNumero(a.Rendimiento));
                }
                lblTotal.Text = $"{agentes.Count} agente(s) encontrado(s)";
            }
            catch (Exception ex)
            {
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                btnFiltrar.Enabled = btnMostrarTodos.Enabled = true;
                UtilidadesGUI.Ocupado(this, false);
            }
        }
    }
}
