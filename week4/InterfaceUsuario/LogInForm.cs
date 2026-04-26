namespace InterfaceUsuario
{
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void borrarDatos()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            const string USUARIO = "Administrador";
            const string CONTRASENA = "Admin1234";

            if(txtUsuario.Text == USUARIO & txtContrasena.Text == CONTRASENA)
            {
                //this.Hide();
                Form frmIngreso = new frmIngreso();
                frmIngreso.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Los datos ingresados no son correctos.\nVerifiquelos y vuelva a intentarlo.",
                    "Error de ingreso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                borrarDatos();
                txtUsuario.Focus();
            }
        }
    }
}
