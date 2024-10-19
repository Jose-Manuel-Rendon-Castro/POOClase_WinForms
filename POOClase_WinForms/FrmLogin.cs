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
            administrador.password = txtBLogin_Contrase�a.Text;

            if (administrador.ValidarCredenciales())
            {
                MessageBox.Show("Inciaste sesi�n");
                FrmMenu frmMenu = new FrmMenu(administrador, listaProductos);
                frmMenu.Show();
            }
            else MessageBox.Show("Credenciales inexistentes o no v�lidas");
        }
    }
}
