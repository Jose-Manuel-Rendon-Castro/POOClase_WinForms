using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class MenuControlador
    {
        private FrmMenuAdmin _frmMenu;
        public MenuControlador(FrmMenuAdmin frmMenu)
        {
            _frmMenu = frmMenu;
            _frmMenu.btnMenu_AgregarProducto.Click += btnMenu_AgregarProducto_Click;
            _frmMenu.btnMenu_BuscarProducto.Click += btnMenu_BuscarProducto_Click;
            _frmMenu.btnMenu_AgregarCategoria.Click += btnMenu_AgregarCategoria_Click;
            _frmMenu.btnMenu_BuscarCategoria.Click += btnMenu_BuscarCategoria_Click;
            _frmMenu.btnMenu_cerrarSesion.Click += btnMenu_cerrarSesion_Click;
            _frmMenu.btnMenu_CrearUsuario.Click += btnMenu_CrearUsuario_Click;
        }
        private void btnMenu_AgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregarProducto = new FrmAgregarProducto();
            frmAgregarProducto.ShowDialog();
        }

        private void btnMenu_BuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frmBuscarProducto = new FrmBuscarProducto();
            frmBuscarProducto.ShowDialog();
        }
        private void btnMenu_AgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria frmAgregarCategoria = new FrmAgregarCategoria();
            frmAgregarCategoria.ShowDialog();
        }
        private void btnMenu_BuscarCategoria_Click(object sender, EventArgs e)
        {
            FrmBuscarCategoria frmBuscarCategoria = new FrmBuscarCategoria();
            frmBuscarCategoria.ShowDialog();
        }
        private void btnMenu_CrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }
        private void btnMenu_cerrarSesion_Click(object sender, EventArgs e)
        {
            _frmMenu.Close();
        }
    }
}
