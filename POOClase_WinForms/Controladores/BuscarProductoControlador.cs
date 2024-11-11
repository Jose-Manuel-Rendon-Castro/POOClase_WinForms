using POOClase_WinForms.AccessData;
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
            if(e.KeyCode == Keys.Enter)
            {
                if(BuscarProductoDAO.BuscarProdutoInfo(_frmBuscarProducto) != null)
                {
                    Producto? producto = BuscarProductoDAO.BuscarProdutoInfo(_frmBuscarProducto);
                    _frmBuscarProducto.lblBuscarProducto_ShowInfo.Text = $"ID: {producto.id}\nCategoria: {producto.categoria}\nNombre: {producto.nombre}\nPrecio: ${producto.precio}\nCodigo de barra: {producto.codigoBarra}\nExistencias: {producto.existencias}";
                }
                else
                {
                    _frmBuscarProducto.lblBuscarProducto_ShowInfo.Text = string.Empty;
                }

            }
        }

        private void btnBuscar_Salir_Click(object sender, EventArgs e)
        {
            _frmBuscarProducto.Close();
        }
    }
}
