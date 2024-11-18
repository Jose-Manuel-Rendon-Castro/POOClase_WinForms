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

        }
            
        private void btnTablasInfo_Salir_Click (object? sender, EventArgs? e)
        {
            _frmTablasInfo.Close();
        }
    }
}
