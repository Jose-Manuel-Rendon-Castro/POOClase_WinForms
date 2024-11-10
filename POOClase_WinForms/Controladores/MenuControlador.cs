using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class MenuControlador
    {
        private FrmMenu _frmMenu;

        public MenuControlador(FrmMenu frmMenu)
        {
            _frmMenu = frmMenu;
            _frmMenu.btnMenu_AgregarProducto.Click += btnMenu_AgregarProducto_Click;
            _frmMenu.btnMenu_BuscarProducto.Click += btnMenu_BuscarProducto_Click;
            _frmMenu.btnMenu_AgregarCategoria.Click += btnMenu_AgregarCategoria_Click;
            _frmMenu.btnMenu_BuscarCategoria.Click += btnMenu_BuscarProducto_Click;
            _frmMenu.btnMenu_cerrarSesion.Click += btnMenu_cerrarSesion_Click;
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
        private void btnMenu_BuscarCategoria_Click(Object sender, EventArgs e)
        {
            FrmBuscarCategoria frmBuscarCategoria = new FrmBuscarCategoria();
            frmBuscarCategoria.ShowDialog();
        }
        private void btnMenu_cerrarSesion_Click(object sender, EventArgs e)
        {
            _frmMenu.Close();
        }
    }
}
