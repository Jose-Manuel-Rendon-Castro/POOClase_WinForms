using POOClase_WinForms.Vistas;
using System.Drawing.Printing;

namespace POOClase_WinForms.Modelos
{
    public class Usuario
    {
        private int _id;
        private string _nombreUsuario;
        private string _contraseña;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _tipoUsuario;

        public int id { get { return _id; } set { _id = value; } }
        public string nombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string contraseña { get { return _contraseña; } set { _contraseña = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public string tipoUsuario { get {return _tipoUsuario; } set { _tipoUsuario = value; } }

        public static bool CheckTxtBox(FrmCrearUsuario frmCrearUsuario)
        {
            return !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_Nombre.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_Apellido.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_Email.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_NombreUsuario.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_Contraseña.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.txtbCrearUsuario_Confirmar.Text) &&
                   !String.IsNullOrEmpty(frmCrearUsuario.combxCrearUsuario_Tipo.Text);
        }
        
        public static bool ConfirmarContraseña(FrmCrearUsuario frmCrearUsuario)
        {
            return frmCrearUsuario.txtbCrearUsuario_Contraseña.Text == frmCrearUsuario.txtbCrearUsuario_Confirmar.Text;
        }
        public static bool EsCorreo(string input_email)
        {
            return input_email.Contains("@gmail.com") ||
                   input_email.Contains("@hotmail.com") ||
                   input_email.Contains("@outlook.com") ||
                   input_email.Contains("@yahoo.com") ||
                   input_email.Contains("icloud.com");
        }
    }
}
