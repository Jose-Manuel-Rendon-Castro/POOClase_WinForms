using POOClase_WinForms.Clases;

namespace POOClase_WinForms
{
    public partial class FrmLogin : Form
    {
        private List<Producto> listaProductos;
        public FrmLogin(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario administrador = new Usuario();

            administrador.username = txtBLogin_Usuario.Text;
            administrador.password = txtBLogin_Contraseña.Text;

            if (administrador.ValidarCredenciales())
            {
                MessageBox.Show("Inciaste sesión");
                FrmMenu frmMenu = new FrmMenu(administrador, listaProductos);
                frmMenu.Show();
            }
            else MessageBox.Show("Credenciales inexistentes o no válidas");
        }
    }
}
