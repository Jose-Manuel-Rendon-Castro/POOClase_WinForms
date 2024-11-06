using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class MenuControlador
    {
        private FrmMenu _frmMenu;

        public MenuControlador(FrmMenu frmMenu)
        {
            _frmMenu = frmMenu;
            _frmMenu.btnAgregarProducto.Click += btnAgregarProducto_Click;
            _frmMenu.btnMenu_Buscar.Click += btnMenu_Buscar_Click;
            _frmMenu.btnMenu_agregarCategoria.Click += btnMenu_agregarCategoria_Click;
            _frmMenu.btnMenu_cerrarSesion.Click += btnMenu_cerrarSesion_Click;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregarProducto = new FrmAgregarProducto();
            frmAgregarProducto.ShowDialog();
        }

        private void btnMenu_Buscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frmBuscarProducto = new FrmBuscarProducto();
            frmBuscarProducto.ShowDialog();
        }
        private void btnMenu_agregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria frmAgregarCategoria = new FrmAgregarCategoria();
            frmAgregarCategoria.ShowDialog();
        }
        private void btnMenu_cerrarSesion_Click(object sender, EventArgs e)
        {
            _frmMenu.Close();
        }
    }
}
