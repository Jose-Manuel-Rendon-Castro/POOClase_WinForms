using System.Drawing.Printing;

namespace POOClase_WinForms.Modelos
{
    public class Usuario
    {
        public String username = "";
        public String password = "";

        public bool ValidarCredenciales()
        {
            if (username == "admin" && password == "123")
            {
                return true;
            }
            else return false;
        }

        public String GetUsername()
        {
            return username;
        }

        public static void login(FrmLogin frmLogin)
        {
            Usuario usuario = new Usuario();

            usuario.username = frmLogin.txtBLogin_Usuario.Text;
            usuario.password = frmLogin.txtBLogin_Contraseña.Text;

            if (usuario.ValidarCredenciales())
            {
                MessageBox.Show("Inciaste sesión");
                FrmMenu frmMenu = new FrmMenu(usuario);
                frmMenu.Show();

                frmLogin.Hide();
            }
            else MessageBox.Show("Credenciales inexistentes o no válidas");
        }
    }
}
