using POOClase_WinForms.AccessData;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class BuscarCategoriaControlador
    {
        private FrmBuscarCategoria _frmBuscarCategoria;

        public BuscarCategoriaControlador(FrmBuscarCategoria frmBuscarCategoria)
        {
            _frmBuscarCategoria = frmBuscarCategoria;
            _frmBuscarCategoria.txtBBuscarCategoria.PreviewKeyDown += txtBBuscarCategoria_PreviewKeyDown;
        }

        private void txtBBuscarCategoria_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Categoria? categoria= BuscarCategoriaDAO.BuscarCategoria(_frmBuscarCategoria);
                _frmBuscarCategoria.lblBuscarCategoria_ShowInfo.Text = $"ID: {categoria.id}\nNombre: {categoria.nombre}\nPrecio Minimo: {categoria.precio_Minimo}";
            }
            else
            {
                _frmBuscarCategoria.lblBuscarCategoria_ShowInfo.Text = string.Empty;
            }
        }

        private void btnBuscarCategoria_Salir(object sender, EventArgs e)
        {
            _frmBuscarCategoria.Close();
        }
    }
}
