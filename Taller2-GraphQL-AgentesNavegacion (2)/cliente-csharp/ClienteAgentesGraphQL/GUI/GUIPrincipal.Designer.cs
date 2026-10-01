namespace ClienteAgentesGraphQL.GUI
{
    partial class GUIPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProbarConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.sepArchivo = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavegacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblEstadoServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuNavegacion,
            this.mnuAyuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Size = new System.Drawing.Size(760, 24);
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProbarConexion,
            this.sepArchivo,
            this.mnuSalir});
            this.mnuArchivo.Text = "&Archivo";
            this.mnuArchivo.Name = "mnuArchivo";
            // 
            // mnuProbarConexion
            // 
            this.mnuProbarConexion.Text = "Probar conexión con el servidor";
            this.mnuProbarConexion.Name = "mnuProbarConexion";
            this.mnuProbarConexion.Click += new System.EventHandler(this.mnuProbarConexion_Click);
            // 
            // sepArchivo
            // 
            this.sepArchivo.Name = "sepArchivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuNavegacion
            // 
            this.mnuNavegacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdicionar,
            this.mnuConsultar,
            this.mnuListar,
            this.mnuEditar,
            this.mnuEliminar});
            this.mnuNavegacion.Text = "Agente de &Navegación";
            this.mnuNavegacion.Name = "mnuNavegacion";
            // 
            // mnuAdicionar
            // 
            this.mnuAdicionar.Text = "Adicionar agente";
            this.mnuAdicionar.Name = "mnuAdicionar";
            this.mnuAdicionar.Click += new System.EventHandler(this.mnuAdicionar_Click);
            // 
            // mnuConsultar
            // 
            this.mnuConsultar.Text = "Consultar agente";
            this.mnuConsultar.Name = "mnuConsultar";
            this.mnuConsultar.Click += new System.EventHandler(this.mnuConsultar_Click);
            // 
            // mnuListar
            // 
            this.mnuListar.Text = "Listar agentes";
            this.mnuListar.Name = "mnuListar";
            this.mnuListar.Click += new System.EventHandler(this.mnuListar_Click);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Text = "Actualizar agente";
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Text = "Eliminar agente";
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercaDe});
            this.mnuAyuda.Text = "A&yuda";
            this.mnuAyuda.Name = "mnuAyuda";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.Text = "Acerca de...";
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblBienvenida.Location = new System.Drawing.Point(20, 90);
            this.lblBienvenida.Size = new System.Drawing.Size(720, 45);
            this.lblBienvenida.Text = "Sistema de Agentes Inteligentes";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Name = "lblBienvenida";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 140);
            this.lblDescripcion.Size = new System.Drawing.Size(720, 60);
            this.lblDescripcion.Text = "Gestión de Agentes de Navegación mediante servicios web GraphQL.\r\nUse el menú \"Agente de Navegación\" para elegir la operación.";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoServidor});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 436);
            this.statusPrincipal.Size = new System.Drawing.Size(760, 24);
            this.statusPrincipal.Name = "statusPrincipal";
            // 
            // lblEstadoServidor
            // 
            this.lblEstadoServidor.Text = "Servidor:";
            this.lblEstadoServidor.Name = "lblEstadoServidor";
            // 
            // GUIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 460);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.statusPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GUIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agentes Inteligentes - Cliente GraphQL";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuProbarConexion;
        private System.Windows.Forms.ToolStripSeparator sepArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuNavegacion;
        private System.Windows.Forms.ToolStripMenuItem mnuAdicionar;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuListar;
        private System.Windows.Forms.ToolStripMenuItem mnuEditar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoServidor;
    }
}
