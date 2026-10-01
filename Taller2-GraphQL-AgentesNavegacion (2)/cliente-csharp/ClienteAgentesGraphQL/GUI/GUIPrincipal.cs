using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>
    /// Ventana principal: solo contiene el menú para navegar a cada caso de uso.
    /// Cada opción abre una ventana independiente (una ventana = un caso de uso).
    /// </summary>
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
            Text = $"{AppInfo.NombreAplicacion} - Cliente GraphQL";
            lblEstadoServidor.Text = "Servidor GraphQL: " + GraphQLService.Endpoint;
        }

        private void AbrirVentana(Form ventana)
        {
            using (ventana)
            {
                ventana.ShowDialog(this);
            }
        }

        // ------------------------------ Archivo ------------------------------

        private async void mnuProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                UtilidadesGUI.Ocupado(this, true);
                await GraphQLService.ProbarConexionAsync();
                UtilidadesGUI.MostrarInformacion(this, "Conexión exitosa con el servidor:\n" + GraphQLService.Endpoint, "Conexión");
            }
            catch (Exception ex)
            {
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                UtilidadesGUI.Ocupado(this, false);
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e) => Application.Exit();

        // ------------------------- Agente de Navegación -------------------------

        private void mnuAdicionar_Click(object sender, EventArgs e) => AbrirVentana(new GUIAdicionarNavegacion());

        private void mnuConsultar_Click(object sender, EventArgs e) => AbrirVentana(new GUIConsultarNavegacion());

        private void mnuListar_Click(object sender, EventArgs e) => AbrirVentana(new GUIListarNavegacion());

        private void mnuEditar_Click(object sender, EventArgs e) => AbrirVentana(new GUIEditarNavegacion());

        private void mnuEliminar_Click(object sender, EventArgs e) => AbrirVentana(new GUIEliminarNavegacion());

        // -------------------------------- Ayuda --------------------------------

        private void mnuAcercaDe_Click(object sender, EventArgs e) => AbrirVentana(new GUIAcercaDe());
    }
}
