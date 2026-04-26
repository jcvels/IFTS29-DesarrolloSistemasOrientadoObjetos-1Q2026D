namespace InterfaceUsuario
{
    partial class frmIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblDocumento = new Label();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            dbgrdIngresos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dbgrdIngresos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(274, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(13, 38);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(13, 99);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 35);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(274, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(98, 96);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(274, 23);
            txtDocumento.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(467, 67);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 52);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(467, 35);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(13, 70);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(98, 67);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(274, 23);
            cboTipo.TabIndex = 3;
            // 
            // dbgrdIngresos
            // 
            dbgrdIngresos.AllowUserToAddRows = false;
            dbgrdIngresos.AllowUserToDeleteRows = false;
            dbgrdIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdIngresos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, TipoDocumento, Documento });
            dbgrdIngresos.Location = new Point(13, 128);
            dbgrdIngresos.Name = "dbgrdIngresos";
            dbgrdIngresos.ReadOnly = true;
            dbgrdIngresos.Size = new Size(529, 177);
            dbgrdIngresos.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 311);
            Controls.Add(dbgrdIngresos);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de datos";
            ((System.ComponentModel.ISupportInitialize)dbgrdIngresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Label lblTipo;
        private ComboBox cboTipo;
        private DataGridView dbgrdIngresos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
    }
}
