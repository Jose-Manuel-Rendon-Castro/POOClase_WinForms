using POOClase_WinForms.DataAccessObject;
using POOClase_WinForms.Vistas.Vistas_Administrador;
using POOClase_WinForms.Exceptions;

namespace POOClase_WinForms.Controladores
{
    public class TablasInfoControlador
    {
        private FrmTablasInfo _frmTablasInfo;
        public TablasInfoControlador(FrmTablasInfo frmTablasInfo) 
        {
            _frmTablasInfo = frmTablasInfo;
            _frmTablasInfo.btnTablaInfo_Salir.Click += btnTablasInfo_Salir_Click;
            _frmTablasInfo.btnTablasInfo_Mostrar.Click += btnTablasInfo_Mostrar_Click;

            _frmTablasInfo.numupTablasInfo_De.Text = string.Empty;
            _frmTablasInfo.numupTablasInfo_Hasta.Text = string.Empty;
        }

        private void btnTablasInfo_Mostrar_Click (object? sender, EventArgs? e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_frmTablasInfo.combxTablasInfo_NombreTabla.Text))
                {
                    TablasInfoDAO.MostrarInfo(
                        _frmTablasInfo.dtgvTablasInfo_Tabla,
                        _frmTablasInfo.combxTablasInfo_NombreTabla.Text
                    );
                }
                else
                {
                    throw new EmptyFieldException();
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool txtBTablasInfo_Buscar_KeyDown()
        {          
                string searchValue = _frmTablasInfo.txtBTablasInfo_ID.Text;

                if (!string.IsNullOrEmpty(searchValue))
                {
                    BuscarYMostrar(_frmTablasInfo.dtgvTablasInfo_Tabla, searchValue);
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor de búsqueda.");
                    return false;
                }
        }

        private void BuscarYMostrar(DataGridView dtgvTablasInfo_Tabla, string searchValue)
        {
            bool found = false;
            foreach (DataGridViewRow row in dtgvTablasInfo_Tabla.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == searchValue)
                    {
                        row.Selected = true;
                        dtgvTablasInfo_Tabla.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true; 
                        return;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("No se encontraron resultados.");   
            }
        }
        private void btnTablasInfo_Salir_Click (object? sender, EventArgs? e)
        {
            _frmTablasInfo.Close();
        }
    }
}
