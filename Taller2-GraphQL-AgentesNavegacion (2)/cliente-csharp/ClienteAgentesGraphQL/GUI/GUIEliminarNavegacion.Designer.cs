namespace ClienteAgentesGraphQL.GUI
{
    partial class GUIEliminarNavegacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblIdAgente = new System.Windows.Forms.Label();
            this.txtIdAgente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoOperativo = new System.Windows.Forms.Label();
            this.txtEstadoOperativo = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblNivelAutonomia = new System.Windows.Forms.Label();
            this.txtNivelAutonomia = new System.Windows.Forms.TextBox();
            this.lblNivelConfianza = new System.Windows.Forms.Label();
            this.txtNivelConfianza = new System.Windows.Forms.TextBox();
            this.lblPrecisionGPS = new System.Windows.Forms.Label();
            this.txtPrecisionGPS = new System.Windows.Forms.TextBox();
            this.lblFechaCalibracion = new System.Windows.Forms.Label();
            this.txtFechaCalibracion = new System.Windows.Forms.TextBox();
            this.lblRendimiento = new System.Windows.Forms.Label();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpBusqueda.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "Eliminar agente de navegación";
            this.lblTitulo.Name = "lblTitulo";
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.lblBuscarId);
            this.grpBusqueda.Controls.Add(this.txtBuscarId);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Location = new System.Drawing.Point(20, 60);
            this.grpBusqueda.Size = new System.Drawing.Size(720, 70);
            this.grpBusqueda.Text = "1. Buscar agente de navegación";
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.TabIndex = 0;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(20, 31);
            this.lblBuscarId.Text = "ID del agente:";
            this.lblBuscarId.Name = "lblBuscarId";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(140, 28);
            this.txtBuscarId.Size = new System.Drawing.Size(110, 23);
            this.txtBuscarId.MaxLength = 9;
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(270, 24);
            this.btnBuscar.Size = new System.Drawing.Size(120, 32);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblIdAgente);
            this.grpResultado.Controls.Add(this.txtIdAgente);
            this.grpResultado.Controls.Add(this.lblNombre);
            this.grpResultado.Controls.Add(this.txtNombre);
            this.grpResultado.Controls.Add(this.lblEstadoOperativo);
            this.grpResultado.Controls.Add(this.txtEstadoOperativo);
            this.grpResultado.Controls.Add(this.lblOrigen);
            this.grpResultado.Controls.Add(this.txtOrigen);
            this.grpResultado.Controls.Add(this.lblDestino);
            this.grpResultado.Controls.Add(this.txtDestino);
            this.grpResultado.Controls.Add(this.lblNivelAutonomia);
            this.grpResultado.Controls.Add(this.txtNivelAutonomia);
            this.grpResultado.Controls.Add(this.lblNivelConfianza);
            this.grpResultado.Controls.Add(this.txtNivelConfianza);
            this.grpResultado.Controls.Add(this.lblPrecisionGPS);
            this.grpResultado.Controls.Add(this.txtPrecisionGPS);
            this.grpResultado.Controls.Add(this.lblFechaCalibracion);
            this.grpResultado.Controls.Add(this.txtFechaCalibracion);
            this.grpResultado.Controls.Add(this.lblRendimiento);
            this.grpResultado.Controls.Add(this.txtRendimiento);
            this.grpResultado.Location = new System.Drawing.Point(20, 145);
            this.grpResultado.Size = new System.Drawing.Size(720, 230);
            this.grpResultado.Text = "2. Verifique TODA la información antes de eliminar";
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.TabIndex = 3;
            // 
            // lblIdAgente
            // 
            this.lblIdAgente.AutoSize = true;
            this.lblIdAgente.Location = new System.Drawing.Point(20, 33);
            this.lblIdAgente.Text = "ID agente:";
            this.lblIdAgente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdAgente.Name = "lblIdAgente";
            // 
            // txtIdAgente
            // 
            this.txtIdAgente.Location = new System.Drawing.Point(140, 30);
            this.txtIdAgente.Size = new System.Drawing.Size(220, 23);
            this.txtIdAgente.ReadOnly = true;
            this.txtIdAgente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdAgente.Name = "txtIdAgente";
            this.txtIdAgente.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 71);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Name = "lblNombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 68);
            this.txtNombre.Size = new System.Drawing.Size(220, 23);
            this.txtNombre.ReadOnly = true;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TabIndex = 5;
            // 
            // lblEstadoOperativo
            // 
            this.lblEstadoOperativo.AutoSize = true;
            this.lblEstadoOperativo.Location = new System.Drawing.Point(20, 109);
            this.lblEstadoOperativo.Text = "Estado operativo:";
            this.lblEstadoOperativo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoOperativo.Name = "lblEstadoOperativo";
            // 
            // txtEstadoOperativo
            // 
            this.txtEstadoOperativo.Location = new System.Drawing.Point(140, 106);
            this.txtEstadoOperativo.Size = new System.Drawing.Size(220, 23);
            this.txtEstadoOperativo.ReadOnly = true;
            this.txtEstadoOperativo.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstadoOperativo.Name = "txtEstadoOperativo";
            this.txtEstadoOperativo.TabIndex = 6;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 147);
            this.lblOrigen.Text = "Origen:";
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigen.Name = "lblOrigen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(140, 144);
            this.txtOrigen.Size = new System.Drawing.Size(220, 23);
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.TabIndex = 7;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 185);
            this.lblDestino.Text = "Destino:";
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Name = "lblDestino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(140, 182);
            this.txtDestino.Size = new System.Drawing.Size(220, 23);
            this.txtDestino.ReadOnly = true;
            this.txtDestino.BackColor = System.Drawing.SystemColors.Window;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.TabIndex = 8;
            // 
            // lblNivelAutonomia
            // 
            this.lblNivelAutonomia.AutoSize = true;
            this.lblNivelAutonomia.Location = new System.Drawing.Point(385, 33);
            this.lblNivelAutonomia.Text = "Nivel autonomía:";
            this.lblNivelAutonomia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNivelAutonomia.Name = "lblNivelAutonomia";
            // 
            // txtNivelAutonomia
            // 
            this.txtNivelAutonomia.Location = new System.Drawing.Point(555, 30);
            this.txtNivelAutonomia.Size = new System.Drawing.Size(145, 23);
            this.txtNivelAutonomia.ReadOnly = true;
            this.txtNivelAutonomia.BackColor = System.Drawing.SystemColors.Window;
            this.txtNivelAutonomia.Name = "txtNivelAutonomia";
            this.txtNivelAutonomia.TabIndex = 9;
            // 
            // lblNivelConfianza
            // 
            this.lblNivelConfianza.AutoSize = true;
            this.lblNivelConfianza.Location = new System.Drawing.Point(385, 71);
            this.lblNivelConfianza.Text = "Nivel confianza:";
            this.lblNivelConfianza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNivelConfianza.Name = "lblNivelConfianza";
            // 
            // txtNivelConfianza
            // 
            this.txtNivelConfianza.Location = new System.Drawing.Point(555, 68);
            this.txtNivelConfianza.Size = new System.Drawing.Size(145, 23);
            this.txtNivelConfianza.ReadOnly = true;
            this.txtNivelConfianza.BackColor = System.Drawing.SystemColors.Window;
            this.txtNivelConfianza.Name = "txtNivelConfianza";
            this.txtNivelConfianza.TabIndex = 10;
            // 
            // lblPrecisionGPS
            // 
            this.lblPrecisionGPS.AutoSize = true;
            this.lblPrecisionGPS.Location = new System.Drawing.Point(385, 109);
            this.lblPrecisionGPS.Text = "Precisión GPS:";
            this.lblPrecisionGPS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecisionGPS.Name = "lblPrecisionGPS";
            // 
            // txtPrecisionGPS
            // 
            this.txtPrecisionGPS.Location = new System.Drawing.Point(555, 106);
            this.txtPrecisionGPS.Size = new System.Drawing.Size(145, 23);
            this.txtPrecisionGPS.ReadOnly = true;
            this.txtPrecisionGPS.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecisionGPS.Name = "txtPrecisionGPS";
            this.txtPrecisionGPS.TabIndex = 11;
            // 
            // lblFechaCalibracion
            // 
            this.lblFechaCalibracion.AutoSize = true;
            this.lblFechaCalibracion.Location = new System.Drawing.Point(385, 147);
            this.lblFechaCalibracion.Text = "Última calibración:";
            this.lblFechaCalibracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaCalibracion.Name = "lblFechaCalibracion";
            // 
            // txtFechaCalibracion
            // 
            this.txtFechaCalibracion.Location = new System.Drawing.Point(555, 144);
            this.txtFechaCalibracion.Size = new System.Drawing.Size(145, 23);
            this.txtFechaCalibracion.ReadOnly = true;
            this.txtFechaCalibracion.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaCalibracion.Name = "txtFechaCalibracion";
            this.txtFechaCalibracion.TabIndex = 12;
            // 
            // lblRendimiento
            // 
            this.lblRendimiento.AutoSize = true;
            this.lblRendimiento.Location = new System.Drawing.Point(385, 185);
            this.lblRendimiento.Text = "Rendimiento:";
            this.lblRendimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRendimiento.Name = "lblRendimiento";
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(555, 182);
            this.txtRendimiento.Size = new System.Drawing.Size(145, 23);
            this.txtRendimiento.ReadOnly = true;
            this.txtRendimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(470, 390);
            this.btnEliminar.Size = new System.Drawing.Size(150, 32);
            this.btnEliminar.Text = "Eliminar agente";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(630, 390);
            this.btnCerrar.Size = new System.Drawing.Size(110, 32);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GUIEliminarNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.btnBuscar;
            this.CancelButton = this.btnCerrar;
            this.Name = "GUIEliminarNavegacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar agente de navegación";
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblIdAgente;
        private System.Windows.Forms.TextBox txtIdAgente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstadoOperativo;
        private System.Windows.Forms.TextBox txtEstadoOperativo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblNivelAutonomia;
        private System.Windows.Forms.TextBox txtNivelAutonomia;
        private System.Windows.Forms.Label lblNivelConfianza;
        private System.Windows.Forms.TextBox txtNivelConfianza;
        private System.Windows.Forms.Label lblPrecisionGPS;
        private System.Windows.Forms.TextBox txtPrecisionGPS;
        private System.Windows.Forms.Label lblFechaCalibracion;
        private System.Windows.Forms.TextBox txtFechaCalibracion;
        private System.Windows.Forms.Label lblRendimiento;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
