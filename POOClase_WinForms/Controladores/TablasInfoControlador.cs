using POOClase_WinForms.Vistas.Vistas_Administrador;

namespace POOClase_WinForms.Controladores
{
    public class TablasInfoControlador
    {
        private FrmTablasInfo _frmTablasInfo;
        public TablasInfoControlador(FrmTablasInfo frmTablasInfo) 
        {
            _frmTablasInfo = frmTablasInfo;
            _frmTablasInfo.Load += frmTablasInfo_Load;
            _frmTablasInfo.btnTablaInfo_Salir.Click += btnTablasInfo_Salir_Click;
        }

        private void frmTablasInfo_Load (object sender, EventArgs e)
        {

        }
        private void btnTablasInfo_Salir_Click (object sender, EventArgs e)
        {
            _frmTablasInfo.Close();
        }
    }
}
