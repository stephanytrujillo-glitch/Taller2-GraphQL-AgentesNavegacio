using ClienteAgentesGraphQL.Model;
using ClienteAgentesGraphQL.Services;

namespace ClienteAgentesGraphQL.GUI
{
    /// <summary>
    /// Caso de uso: ACTUALIZAR un agente.
    /// Primero se busca y se muestra TODA su información en campos editables;
    /// luego el usuario modifica uno o varios atributos y guarda los cambios.
    /// </summary>
    public partial class GUIEditarNavegacion : Form
    {
        private AgenteNavegacion agenteEncontrado;

        public GUIEditarNavegacion()
        {
            InitializeComponent();
            HabilitarEdicion(false);
            txtBuscarId.TextChanged += (s, e) =>
            {
                agenteEncontrado = null;
                LimpiarDatos();
                HabilitarEdicion(false);
            };
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
                    LimpiarDatos();
                    HabilitarEdicion(false);
                    UtilidadesGUI.MostrarInformacion(this, $"No existe un agente de navegación con ID {id}.", "Consulta");
                    return;
                }
                CargarDatos(agenteEncontrado);
                HabilitarEdicion(true);
                txtNombre.Focus();
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

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (agenteEncontrado == null) return;

            if (!UtilidadesGUI.LeerTexto(this, txtNombre, "El nombre", out string nombre)) return;
            if (!UtilidadesGUI.LeerTexto(this, txtOrigen, "El origen", out string origen)) return;
            if (!UtilidadesGUI.LeerTexto(this, txtDestino, "El destino", out string destino)) return;
            if (!UtilidadesGUI.LeerDecimal(this, txtNivelAutonomia, "El nivel de autonomía", 0, 100, out double autonomia)) return;
            if (!UtilidadesGUI.LeerDecimal(this, txtNivelConfianza, "El nivel de confianza", 0, 100, out double confianza)) return;
            if (!UtilidadesGUI.LeerDecimal(this, txtPrecisionGPS, "La precisión GPS", 0, 100, out double precision)) return;

            var input = new AgenteNavegacionInput
            {
                IdAgente = agenteEncontrado.IdAgente, // el ID no se modifica
                Nombre = nombre,
                NivelAutonomia = autonomia,
                EstadoOperativo = cmbEstadoOperativo.SelectedItem?.ToString() ?? agenteEncontrado.EstadoOperativo,
                NivelConfianza = confianza,
                Origen = origen,
                Destino = destino,
                PrecisionGPS = precision,
                FechaUltimaCalibracion = AgenteNavegacionInput.FormatearFecha(dtpFechaCalibracion.Value)
            };

            try
            {
                btnActualizar.Enabled = false;
                UtilidadesGUI.Ocupado(this, true);
                agenteEncontrado = await GraphQLService.ActualizarAsync(input);
                CargarDatos(agenteEncontrado);
                UtilidadesGUI.MostrarInformacion(this,
                    $"El agente \"{agenteEncontrado.Nombre}\" (ID {agenteEncontrado.IdAgente}) se actualizó correctamente.\n" +
                    $"Nuevo rendimiento: {UtilidadesGUI.FormatearNumero(agenteEncontrado.Rendimiento)}", "Operación exitosa");
            }
            catch (Exception ex)
            {
                UtilidadesGUI.MostrarError(this, ex);
            }
            finally
            {
                btnActualizar.Enabled = agenteEncontrado != null;
                UtilidadesGUI.Ocupado(this, false);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();

        private void CargarDatos(AgenteNavegacion a)
        {
            txtIdAgente.Text = a.IdAgente.ToString();
            txtNombre.Text = a.Nombre;
            cmbEstadoOperativo.SelectedItem = a.EstadoOperativo;
            txtOrigen.Text = a.Origen;
            txtDestino.Text = a.Destino;
            txtNivelAutonomia.Text = UtilidadesGUI.FormatearNumero(a.NivelAutonomia);
            txtNivelConfianza.Text = UtilidadesGUI.FormatearNumero(a.NivelConfianza);
            txtPrecisionGPS.Text = UtilidadesGUI.FormatearNumero(a.PrecisionGPS);
            UtilidadesGUI.AsignarFecha(dtpFechaCalibracion, a.ObtenerFechaCalibracion());
        }

        private void LimpiarDatos()
        {
            UtilidadesGUI.LimpiarCampos(txtIdAgente, txtNombre, txtOrigen, txtDestino,
                txtNivelAutonomia, txtNivelConfianza, txtPrecisionGPS);
            cmbEstadoOperativo.SelectedIndex = -1;
            dtpFechaCalibracion.Value = DateTime.Now;
        }

        private void HabilitarEdicion(bool habilitar)
        {
            grpDatos.Enabled = habilitar;
            btnActualizar.Enabled = habilitar;
        }
    }
}
