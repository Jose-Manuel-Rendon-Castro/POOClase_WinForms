using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.AccessData
{
    public class LoginDAO
    {
        private static readonly string connectionString = "Server=localhost;Database=tienda;Uid=root;Pwd=23040273";

        public static Usuario? IniciarSesion(FrmLogin frmLogin)
        {
            string loginQuery = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";
            string input_nombreUsuario = frmLogin.txtBLogin_Usuario.Text;
            string input_contraseña = frmLogin.txtBLogin_Contraseña.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand loginCommand = new MySqlCommand (loginQuery, conn)) 
                {
                    loginCommand.Parameters.AddWithValue("@nombre_usuario", input_nombreUsuario);
                    loginCommand.Parameters.AddWithValue("@contraseña", input_contraseña);
                    int result = Convert.ToInt32(loginCommand.ExecuteScalar());
                    if(result > 0)
                    {
                        Usuario? usuario = LoginDAO.getUsuarioData(frmLogin);
                        return usuario;
                    }
                    else { return null; }
                }
            }
        }
        private static Usuario? getUsuarioData(FrmLogin frmLogin)
        {
            string getDataQuery = "SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";
            string input_nombreUsuario = frmLogin.txtBLogin_Usuario.Text.Trim();
            string input_contraseña = frmLogin.txtBLogin_Contraseña.Text.Trim();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand getDataCommand = new MySqlCommand(getDataQuery, conn))
                {
                    getDataCommand.Parameters.AddWithValue("@nombre_usuario", input_nombreUsuario);
                    getDataCommand.Parameters.AddWithValue("@contraseña", input_contraseña);
                    using (MySqlDataReader reader = getDataCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                id = reader.GetInt32("id"),
                                nombreUsuario = reader.GetString("nombre_usuario"),
                                contraseña = reader.GetString("contraseña"),
                                nombre = reader.GetString("nombre"),
                                apellido = reader.GetString("apellido"),
                                email = reader.GetString("email")
                            };
                            return usuario;
                        }
                        else { return null; }
                    }
                }
            }
        }
    }
}
