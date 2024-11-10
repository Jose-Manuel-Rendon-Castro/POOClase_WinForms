using POOClase_WinForms.AccessData;
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
            AgregarProductoDAO.AgregarPrducto(_frmAgregarProducto);
            _frmAgregarProducto.Close();
        }
    }
}
