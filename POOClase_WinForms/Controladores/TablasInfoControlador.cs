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
        }

        private void btnTablasInfo_Mostrar_Click (object sender, EventArgs e)
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
        private void btnTablasInfo_Salir_Click (object sender, EventArgs e)
        {
            _frmTablasInfo.Close();
        }
    }
}
