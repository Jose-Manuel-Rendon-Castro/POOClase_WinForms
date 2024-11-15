using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Exceptions;

namespace POOClase_WinForms.AccessData
{
    public class CrearUsuarioDAO : ConnectionString
    {
        public static bool CrearUsuario(string input_nombreUsuario, string input_contraseña, string input_nombre, string input_apellido, string input_email, string input_tipoUsuario)
        {
            string insertQuery = "INSERT INTO usuarios (id, nombre_usuario, contraseña, nombre, apellido, email, tipoUsuario) VALUES (@id, @nombre_usuario, @contraseña, @nombre, @apellido, @email, @tipoUsuario)";
            string nextIdQuery = "SELECT COUNT(*) FROM usuarios";
            int input_id;
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand nextIdCommand = new MySqlCommand(nextIdQuery, conn))
                    {
                        input_id = Convert.ToInt32(nextIdCommand.ExecuteScalar()) + 1;
                    }
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@id", input_id);
                        insertCommand.Parameters.AddWithValue("@nombre_usuario", input_nombreUsuario);
                        insertCommand.Parameters.AddWithValue("@contraseña", input_contraseña);
                        insertCommand.Parameters.AddWithValue("@nombre", input_nombre);
                        insertCommand.Parameters.AddWithValue("@apellido", input_apellido);
                        insertCommand.Parameters.AddWithValue("@email", input_email);
                        insertCommand.Parameters.AddWithValue("@tipoUsuario", input_tipoUsuario);
                        Usuario newUser = CheckCredencialesIguales(input_nombreUsuario, input_email);
                        if (!Usuario.EsCorreo(input_email))
                        {
                            throw new NotEmailException();
                        }
                        if(input_nombreUsuario == newUser.nombreUsuario)
                        {
                            throw new ValuesAreEqualException("Ya existe un usuario con el mismo nombre de usuario");
                        }
                        if (input_email == newUser.email)
                        {
                            throw new ValuesAreEqualException("Ya existe un usuario con el mismo correo electrónico");
                        }
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha creado el usuario", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (ValuesAreEqualException ex)
            {
                MessageBox.Show(ex.Message, "Datos existentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch (NotEmailException ex)
            {
                MessageBox.Show(ex.Message, "Error en Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static Usuario CheckCredencialesIguales(string input_nombreUsuario, string input_email)
        {
            string selectNombreUsuarioQuery = "SELECT nombre_usuario FROM usuarios WHERE nombre_usuario = @nombre_usuario";
            string selectEmailQuery = "SELECT email FROM usuarios WHERE email = @email";
            Usuario userToCheck = new Usuario();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectNombreUsuarioCommand = new MySqlCommand(selectNombreUsuarioQuery, conn))
                {
                    selectNombreUsuarioCommand.Parameters.AddWithValue("@nombre_usuario", input_nombreUsuario);
                    userToCheck.nombreUsuario = (string)selectNombreUsuarioCommand.ExecuteScalar();
                }
                using (MySqlCommand selectEmailCommand = new MySqlCommand(selectEmailQuery, conn))
                {
                    selectEmailCommand.Parameters.AddWithValue("@email", input_email);
                    userToCheck.email = (string)selectEmailCommand.ExecuteScalar();
                }
                return userToCheck;
            }
        }
    }
}
