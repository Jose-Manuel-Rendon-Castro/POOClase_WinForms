using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.AccessData
{
    public class LoginDAO : ConnectionString
    {
        public static Usuario? IniciarSesion(string input_nombreUsuario, string input_contraseña)
        {
            string loginQuery = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";

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
                        Usuario? usuario = LoginDAO.getUsuarioData(input_nombreUsuario, input_contraseña);
                        return usuario;
                    }
                    else { return null; }
                }
            }
        }
        private static Usuario? getUsuarioData(string input_nombreUsuario, string input_contraseña)
        {
            string getDataQuery = "SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand getDataCommand = new MySqlCommand(getDataQuery, conn))
                {
                    getDataCommand.Parameters.AddWithValue("@nombre_usuario", input_nombreUsuario.Trim());
                    getDataCommand.Parameters.AddWithValue("@contraseña", input_contraseña.Trim());
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
                                email = reader.GetString("email"),
                                tipoUsuario = reader.GetString("tipoUsuario")
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
