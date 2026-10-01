namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>Ventana "Ayuda > Acerca de...": integrantes del equipo y versión.</summary>
    public partial class GUIAcercaDe : Form
    {
        public GUIAcercaDe()
        {
            InitializeComponent();
            lblTitulo.Text = AppInfo.NombreAplicacion;
            lblVersion.Text = "Versión: " + AppInfo.Version;
            lblIntegrantes.Text = string.Join(Environment.NewLine, AppInfo.Integrantes.Select(n => "•  " + n));
        }

        private void btnAceptar_Click(object sender, EventArgs e) => Close();
    }
}
