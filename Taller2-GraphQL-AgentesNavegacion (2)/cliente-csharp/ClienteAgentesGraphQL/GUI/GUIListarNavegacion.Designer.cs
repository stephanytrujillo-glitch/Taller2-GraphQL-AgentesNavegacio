namespace ClienteAgentesGraphQL.GUI
{
    partial class GUIListarNavegacion
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvAgentes = new System.Windows.Forms.DataGridView();
            this.colIdAgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRendimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "Listar agentes de navegación";
            this.lblTitulo.Name = "lblTitulo";
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblFiltroNombre);
            this.grpFiltros.Controls.Add(this.txtFiltroNombre);
            this.grpFiltros.Controls.Add(this.lblFiltroEstado);
            this.grpFiltros.Controls.Add(this.cmbFiltroEstado);
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.btnMostrarTodos);
            this.grpFiltros.Location = new System.Drawing.Point(20, 60);
            this.grpFiltros.Size = new System.Drawing.Size(800, 70);
            this.grpFiltros.Text = "Filtros (se aplican en el servidor)";
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.TabIndex = 0;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(15, 31);
            this.lblFiltroNombre.Text = "Nombre contiene:";
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(125, 28);
            this.txtFiltroNombre.Size = new System.Drawing.Size(190, 23);
            this.txtFiltroNombre.MaxLength = 60;
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.TabIndex = 1;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(330, 31);
            this.lblFiltroEstado.Text = "Estado operativo:";
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "ACTIVO",
            "INACTIVO",
            "MANTENIMIENTO"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(440, 28);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(140, 23);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.Location = new System.Drawing.Point(595, 24);
            this.btnFiltrar.Size = new System.Drawing.Size(90, 32);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnMostrarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarTodos.Location = new System.Drawing.Point(695, 24);
            this.btnMostrarTodos.Size = new System.Drawing.Size(95, 32);
            this.btnMostrarTodos.Text = "Ver todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvAgentes
            // 
            this.dgvAgentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAgente,
            this.colNombre,
            this.colEstado,
            this.colAutonomia,
            this.colConfianza,
            this.colOrigen,
            this.colDestino,
            this.colPrecision,
            this.colFecha,
            this.colRendimiento});
            this.dgvAgentes.AllowUserToAddRows = false;
            this.dgvAgentes.AllowUserToDeleteRows = false;
            this.dgvAgentes.AllowUserToResizeRows = false;
            this.dgvAgentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentes.Location = new System.Drawing.Point(20, 145);
            this.dgvAgentes.MultiSelect = false;
            this.dgvAgentes.ReadOnly = true;
            this.dgvAgentes.RowHeadersVisible = false;
            this.dgvAgentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgentes.Size = new System.Drawing.Size(1060, 350);
            this.dgvAgentes.Name = "dgvAgentes";
            this.dgvAgentes.TabIndex = 5;
            // 
            // colIdAgente
            // 
            this.colIdAgente.FillWeight = 35F;
            this.colIdAgente.HeaderText = "ID";
            this.colIdAgente.ReadOnly = true;
            this.colIdAgente.Name = "colIdAgente";
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 110F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Name = "colNombre";
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 85F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Name = "colEstado";
            // 
            // colAutonomia
            // 
            this.colAutonomia.FillWeight = 65F;
            this.colAutonomia.HeaderText = "Autonomía";
            this.colAutonomia.ReadOnly = true;
            this.colAutonomia.Name = "colAutonomia";
            // 
            // colConfianza
            // 
            this.colConfianza.FillWeight = 65F;
            this.colConfianza.HeaderText = "Confianza";
            this.colConfianza.ReadOnly = true;
            this.colConfianza.Name = "colConfianza";
            // 
            // colOrigen
            // 
            this.colOrigen.FillWeight = 120F;
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.ReadOnly = true;
            this.colOrigen.Name = "colOrigen";
            // 
            // colDestino
            // 
            this.colDestino.FillWeight = 120F;
            this.colDestino.HeaderText = "Destino";
            this.colDestino.ReadOnly = true;
            this.colDestino.Name = "colDestino";
            // 
            // colPrecision
            // 
            this.colPrecision.FillWeight = 70F;
            this.colPrecision.HeaderText = "Precisión GPS";
            this.colPrecision.ReadOnly = true;
            this.colPrecision.Name = "colPrecision";
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 100F;
            this.colFecha.HeaderText = "Última calibración";
            this.colFecha.ReadOnly = true;
            this.colFecha.Name = "colFecha";
            // 
            // colRendimiento
            // 
            this.colRendimiento.FillWeight = 70F;
            this.colRendimiento.HeaderText = "Rendimiento";
            this.colRendimiento.ReadOnly = true;
            this.colRendimiento.Name = "colRendimiento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 512);
            this.lblTotal.Text = "0 agente(s)";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.Name = "lblTotal";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(970, 508);
            this.btnCerrar.Size = new System.Drawing.Size(110, 32);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GUIListarNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dgvAgentes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCerrar);
            this.AcceptButton = this.btnFiltrar;
            this.CancelButton = this.btnCerrar;
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "GUIListarNavegacion";
            this.Load += new System.EventHandler(this.GUIListarNavegacion_Load);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar agentes de navegación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvAgentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRendimiento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCerrar;
    }
}
