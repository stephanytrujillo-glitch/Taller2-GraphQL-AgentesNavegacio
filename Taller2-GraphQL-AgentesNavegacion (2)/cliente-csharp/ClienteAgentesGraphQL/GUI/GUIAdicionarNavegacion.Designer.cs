namespace ClienteAgentesGraphQL.GUI
{
    partial class GUIAdicionarNavegacion
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblIdAgente = new System.Windows.Forms.Label();
            this.txtIdAgente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoOperativo = new System.Windows.Forms.Label();
            this.cmbEstadoOperativo = new System.Windows.Forms.ComboBox();
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
            this.dtpFechaCalibracion = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "Adicionar agente de navegación";
            this.lblTitulo.Name = "lblTitulo";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblIdAgente);
            this.grpDatos.Controls.Add(this.txtIdAgente);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblEstadoOperativo);
            this.grpDatos.Controls.Add(this.cmbEstadoOperativo);
            this.grpDatos.Controls.Add(this.lblOrigen);
            this.grpDatos.Controls.Add(this.txtOrigen);
            this.grpDatos.Controls.Add(this.lblDestino);
            this.grpDatos.Controls.Add(this.txtDestino);
            this.grpDatos.Controls.Add(this.lblNivelAutonomia);
            this.grpDatos.Controls.Add(this.txtNivelAutonomia);
            this.grpDatos.Controls.Add(this.lblNivelConfianza);
            this.grpDatos.Controls.Add(this.txtNivelConfianza);
            this.grpDatos.Controls.Add(this.lblPrecisionGPS);
            this.grpDatos.Controls.Add(this.txtPrecisionGPS);
            this.grpDatos.Controls.Add(this.lblFechaCalibracion);
            this.grpDatos.Controls.Add(this.dtpFechaCalibracion);
            this.grpDatos.Location = new System.Drawing.Point(20, 60);
            this.grpDatos.Size = new System.Drawing.Size(720, 225);
            this.grpDatos.Text = "Datos del nuevo agente";
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.TabIndex = 0;
            // 
            // lblIdAgente
            // 
            this.lblIdAgente.AutoSize = true;
            this.lblIdAgente.Location = new System.Drawing.Point(20, 33);
            this.lblIdAgente.Text = "ID agente:";
            this.lblIdAgente.Name = "lblIdAgente";
            // 
            // txtIdAgente
            // 
            this.txtIdAgente.Location = new System.Drawing.Point(140, 30);
            this.txtIdAgente.Size = new System.Drawing.Size(110, 23);
            this.txtIdAgente.MaxLength = 9;
            this.txtIdAgente.Name = "txtIdAgente";
            this.txtIdAgente.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 71);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Name = "lblNombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 68);
            this.txtNombre.Size = new System.Drawing.Size(220, 23);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TabIndex = 2;
            // 
            // lblEstadoOperativo
            // 
            this.lblEstadoOperativo.AutoSize = true;
            this.lblEstadoOperativo.Location = new System.Drawing.Point(20, 109);
            this.lblEstadoOperativo.Text = "Estado operativo:";
            this.lblEstadoOperativo.Name = "lblEstadoOperativo";
            // 
            // cmbEstadoOperativo
            // 
            this.cmbEstadoOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOperativo.FormattingEnabled = true;
            this.cmbEstadoOperativo.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO",
            "MANTENIMIENTO"});
            this.cmbEstadoOperativo.Location = new System.Drawing.Point(140, 106);
            this.cmbEstadoOperativo.Size = new System.Drawing.Size(160, 23);
            this.cmbEstadoOperativo.Name = "cmbEstadoOperativo";
            this.cmbEstadoOperativo.TabIndex = 3;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 147);
            this.lblOrigen.Text = "Origen:";
            this.lblOrigen.Name = "lblOrigen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(140, 144);
            this.txtOrigen.Size = new System.Drawing.Size(220, 23);
            this.txtOrigen.MaxLength = 80;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 185);
            this.lblDestino.Text = "Destino:";
            this.lblDestino.Name = "lblDestino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(140, 182);
            this.txtDestino.Size = new System.Drawing.Size(220, 23);
            this.txtDestino.MaxLength = 80;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.TabIndex = 5;
            // 
            // lblNivelAutonomia
            // 
            this.lblNivelAutonomia.AutoSize = true;
            this.lblNivelAutonomia.Location = new System.Drawing.Point(385, 33);
            this.lblNivelAutonomia.Text = "Nivel autonomía (0-100):";
            this.lblNivelAutonomia.Name = "lblNivelAutonomia";
            // 
            // txtNivelAutonomia
            // 
            this.txtNivelAutonomia.Location = new System.Drawing.Point(555, 30);
            this.txtNivelAutonomia.Size = new System.Drawing.Size(110, 23);
            this.txtNivelAutonomia.MaxLength = 6;
            this.txtNivelAutonomia.Name = "txtNivelAutonomia";
            this.txtNivelAutonomia.TabIndex = 6;
            // 
            // lblNivelConfianza
            // 
            this.lblNivelConfianza.AutoSize = true;
            this.lblNivelConfianza.Location = new System.Drawing.Point(385, 71);
            this.lblNivelConfianza.Text = "Nivel confianza (0-100):";
            this.lblNivelConfianza.Name = "lblNivelConfianza";
            // 
            // txtNivelConfianza
            // 
            this.txtNivelConfianza.Location = new System.Drawing.Point(555, 68);
            this.txtNivelConfianza.Size = new System.Drawing.Size(110, 23);
            this.txtNivelConfianza.MaxLength = 6;
            this.txtNivelConfianza.Name = "txtNivelConfianza";
            this.txtNivelConfianza.TabIndex = 7;
            // 
            // lblPrecisionGPS
            // 
            this.lblPrecisionGPS.AutoSize = true;
            this.lblPrecisionGPS.Location = new System.Drawing.Point(385, 109);
            this.lblPrecisionGPS.Text = "Precisión GPS (0-100):";
            this.lblPrecisionGPS.Name = "lblPrecisionGPS";
            // 
            // txtPrecisionGPS
            // 
            this.txtPrecisionGPS.Location = new System.Drawing.Point(555, 106);
            this.txtPrecisionGPS.Size = new System.Drawing.Size(110, 23);
            this.txtPrecisionGPS.MaxLength = 6;
            this.txtPrecisionGPS.Name = "txtPrecisionGPS";
            this.txtPrecisionGPS.TabIndex = 8;
            // 
            // lblFechaCalibracion
            // 
            this.lblFechaCalibracion.AutoSize = true;
            this.lblFechaCalibracion.Location = new System.Drawing.Point(385, 147);
            this.lblFechaCalibracion.Text = "Última calibración:";
            this.lblFechaCalibracion.Name = "lblFechaCalibracion";
            // 
            // dtpFechaCalibracion
            // 
            this.dtpFechaCalibracion.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dtpFechaCalibracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCalibracion.Location = new System.Drawing.Point(555, 144);
            this.dtpFechaCalibracion.Size = new System.Drawing.Size(145, 23);
            this.dtpFechaCalibracion.Name = "dtpFechaCalibracion";
            this.dtpFechaCalibracion.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(390, 300);
            this.btnGuardar.Size = new System.Drawing.Size(110, 32);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(510, 300);
            this.btnLimpiar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(630, 300);
            this.btnCerrar.Size = new System.Drawing.Size(110, 32);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GUIAdicionarNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnCerrar;
            this.Name = "GUIAdicionarNavegacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar agente de navegación";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblIdAgente;
        private System.Windows.Forms.TextBox txtIdAgente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEstadoOperativo;
        private System.Windows.Forms.ComboBox cmbEstadoOperativo;
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
        private System.Windows.Forms.DateTimePicker dtpFechaCalibracion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
