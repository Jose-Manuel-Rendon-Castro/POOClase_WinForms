using System.Drawing.Printing;

namespace POOClase_WinForms.Clases
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

    }
}
