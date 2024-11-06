using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.Controladores
{
    public class LoginControlador
    {
        private FrmLogin _frmLogin;

        public LoginControlador(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;
            _frmLogin.btnLogin.Click += btnLogin_Click;
            _frmLogin.btnLogin_Salir.Click += btnLogin_Salir_Click;
            _frmLogin.Deactivate += FrmLogin_Deactivate;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario.login(_frmLogin);
        }

        private void btnLogin_Salir_Click(object sender, EventArgs e)
        {
            _frmLogin.Close();
        }

        private void FrmLogin_Deactivate(object sender, EventArgs e)
        {
            _frmLogin.txtBLogin_Usuario.Text = "";
            _frmLogin.txtBLogin_Contraseña.Text = "";
        }
    }
}
