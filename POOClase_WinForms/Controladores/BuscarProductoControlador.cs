using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.Controladores
{
    public class BuscarProductoControlador
    {
        private FrmBuscarProducto _frmBuscarProducto;

        public BuscarProductoControlador(FrmBuscarProducto frmBuscarProducto)
        {
            _frmBuscarProducto = frmBuscarProducto;
            _frmBuscarProducto.txtBBuscar.PreviewKeyDown += txtBBuscar_PreviewKeyDown;
            _frmBuscarProducto.btnBuscar_Salir.Click += btnBuscar_Salir_Click;
        }
        private void txtBBuscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnBuscar_Salir_Click(object sender, EventArgs e)
        {
            _frmBuscarProducto.Close();
        }
    }
}
