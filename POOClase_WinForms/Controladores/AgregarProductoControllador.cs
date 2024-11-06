using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.Controladores
{
    public class AgregarProductoControllador
    {
        private FrmAgregarProducto _frmAgregarProducto;
        public AgregarProductoControllador(FrmAgregarProducto frmAgregarProducto)
        {
            _frmAgregarProducto = frmAgregarProducto;
            _frmAgregarProducto.btnAgregarProducto_Agregar.Click += btnAgregarProcuto_Agregar_Click;
        }
        private void btnAgregarProcuto_Agregar_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto();
            productoNuevo.AgregarProducto(_frmAgregarProducto);
            _frmAgregarProducto.Close();
        }

    }
}
