using POOClase_WinForms.AccessData;
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
            Usuario? userOnUse = LoginDAO.IniciarSesion(_frmLogin.txtBLogin_Usuario.Text, _frmLogin.txtBLogin_Contraseña.Text);
            if(userOnUse != null)
            {
                FrmMenuAdmin frmMenu = new FrmMenuAdmin(userOnUse);                
                MessageBox.Show("Inciaste sesión");
                _frmLogin.Hide();
                frmMenu.lblMenu_Bienvenido.Text = $"Bienvenido {userOnUse.nombreUsuario}";
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales no coinciden o inexistentes");
                return;
            }
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
