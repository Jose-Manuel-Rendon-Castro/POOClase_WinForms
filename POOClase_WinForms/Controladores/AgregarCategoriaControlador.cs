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
            _frmAgregarCategoria.btnBuscarCategoria.Click += btnBuscarCategoria_Click;
        }

        private void btnAgregarCategoria_Agregar_Click(object sender, EventArgs e)
        {
            CategoriaDAO nuevacCategoria = new CategoriaDAO();
            nuevacCategoria.AgregarCategoria(_frmAgregarCategoria);
        }
        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            
        }

    }
}
