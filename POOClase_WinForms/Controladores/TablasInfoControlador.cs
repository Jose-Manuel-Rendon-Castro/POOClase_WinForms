using POOClase_WinForms.DataAccessObject;
using POOClase_WinForms.Vistas.Vistas_Administrador;
using POOClase_WinForms.Exceptions;
using POOClase_WinForms.DataAccessObject.ModelosDAO;

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
            _frmTablasInfo.btnTablasInfo_Limpiar.Click += btnTablasInfo_Limpiar_Click;
            _frmTablasInfo.combxTablasInfo_NombreTabla.SelectedIndexChanged += combxTablasInfo_NombreTabla_SelectedIndexChanged;

            _frmTablasInfo.numupTablasInfo_De.Text = string.Empty;
            _frmTablasInfo.numupTablasInfo_Hasta.Text = string.Empty;
            LlenarComboBoxTablas();
        }

        private void combxTablasInfo_NombreTabla_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            if (_frmTablasInfo.combxTablasInfo_NombreTabla.SelectedItem?.ToString() == "categorias")
            {
                _frmTablasInfo.txtBTablasInfo_NombreCategoria.Text = string.Empty;
                _frmTablasInfo.txtBTablasInfo_NombreCategoria.Enabled = false;
            }
            else
            {
                _frmTablasInfo.txtBTablasInfo_NombreCategoria.Enabled = true;
            }
        }
        private void btnTablasInfo_Limpiar_Click (object? sender, EventArgs? e)
        {
            _frmTablasInfo.combxTablasInfo_NombreTabla.SelectedItem = null;
            _frmTablasInfo.txtBTablasInfo_ID.Text = string.Empty;  
            _frmTablasInfo.txtBTablasInfo_NombreCategoria.Text = string.Empty;
            _frmTablasInfo.txtBTablasInfo_NombreElemento.Text = string.Empty;
            _frmTablasInfo.numupTablasInfo_De.Text = string.Empty;
            _frmTablasInfo.numupTablasInfo_Hasta.Text = string.Empty;
        }
        private void btnTablasInfo_Mostrar_Click (object? sender, EventArgs? e)
        {
            try
            {
                if (_frmTablasInfo.combxTablasInfo_NombreTabla.SelectedItem == null)                
                {
                    throw new EmptyFieldException();
                }
                if (_frmTablasInfo.numupTablasInfo_De.Value > _frmTablasInfo.numupTablasInfo_Hasta.Value)
                {
                    throw new Exception();
                }

                TablasInfoDAO.MostrarTabla
                (
                    _frmTablasInfo.dtgvTablasInfo_Tabla,
                    _frmTablasInfo.combxTablasInfo_NombreTabla.Text,
                    _frmTablasInfo.txtBTablasInfo_ID.Text,
                    _frmTablasInfo.txtBTablasInfo_NombreElemento.Text,
                    _frmTablasInfo.txtBTablasInfo_NombreCategoria.Text,
                    _frmTablasInfo.numupTablasInfo_De.Text,
                    _frmTablasInfo.numupTablasInfo_Hasta.Text
                );
                if (_frmTablasInfo.dtgvTablasInfo_Tabla.RowCount == 0)
                {
                    MessageBox.Show("No se encontraron datos", "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El valor máximo del rango de precio no puede ser menor que el valor mínimo. Por favor, ajuste los valores e intentenuevamente", 
                    "Error en rango de precio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LlenarComboBoxTablas()
        {
            try
            {
                var categorias = BaseDatosTablasDAO.ObtenerTablas();
                _frmTablasInfo.combxTablasInfo_NombreTabla.Items.AddRange(categorias.ToArray());            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tablas {ex.Message}");
            }
        }
            
        private void btnTablasInfo_Salir_Click (object? sender, EventArgs? e)
        {
            _frmTablasInfo.Close();
        }
    }
}
