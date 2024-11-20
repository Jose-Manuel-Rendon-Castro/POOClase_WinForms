using POOClase_WinForms.AccessData;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class AgregarCategoriaControlador
    {
        private FrmAgregarCategoria _frmAgregarCategoria;

        public AgregarCategoriaControlador(FrmAgregarCategoria frmAgregarCategoria)
        {
            _frmAgregarCategoria = frmAgregarCategoria;
            _frmAgregarCategoria.btnAgregarCategoria_Agregar.Click += btnAgregarCategoria_Agregar_Click;
            _frmAgregarCategoria.btnAgregarCategoria_Salir.Click += btnAgregarCategoria_Salir_Click;
        }

        private void btnAgregarCategoria_Agregar_Click(object? sender, EventArgs? e)
        {
            AgregarCategoriaDAO.AgregarCategoria(_frmAgregarCategoria.txtBNombreCategoria.Text, _frmAgregarCategoria.txtBPrecioMinimo.Text);
        }
        private void btnAgregarCategoria_Salir_Click(object? sender, EventArgs? e)
        {
            _frmAgregarCategoria.Close();
        }

    }
}
