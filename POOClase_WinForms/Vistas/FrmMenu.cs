using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmMenu : Form
    {
        private List<Producto> listaProductos;
        private FrmLogin frmLogin;
        public FrmMenu(FrmLogin frmLogin, Usuario usuario, List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            this.frmLogin = frmLogin;
            lblMenu_Bienvenido.Text = $"Bienvenido {usuario.GetUsername()}";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregarProducto = new FrmAgregarProducto(listaProductos);
            frmAgregarProducto.ShowDialog();
        }

        private void btnMenu_Buscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frmBuscarProducto = new FrmBuscarProducto(listaProductos);
            frmBuscarProducto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            frmLogin.Show();
        }
    }
}
