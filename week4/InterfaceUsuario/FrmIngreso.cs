namespace InterfaceUsuario
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();

            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Extranjero");
        }

        private void btnIngresar_Click(object sender, EventArgs e) // onClick -> INGRESAR
        {
            var postulante = new Postulante(
                txtNombre.Text,
                txtApellido.Text,
                cboTipo.Text,
                int.Parse(
                    txtDocumento.Text
                )
            );

            int row = dbgrdIngresos.Rows.Add();

            dbgrdIngresos.Rows[row].Cells[0].Value = postulante.Nombre;
            dbgrdIngresos.Rows[row].Cells[1].Value = postulante.Apellido;
            dbgrdIngresos.Rows[row].Cells[2].Value = postulante.Tipo;
            dbgrdIngresos.Rows[row].Cells[3].Value = postulante.Documento;

            btnLimpiar_Click(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtDocumento.Text = String.Empty;
            cboTipo.Text = String.Empty;
        }
    }
}
