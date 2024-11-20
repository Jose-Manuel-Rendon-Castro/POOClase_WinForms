using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.DataAccessObject.ModelosDAO
{
    public class CategoriaDAO : ConnectionString
    {
        public static List<string> ObtenerCategorias()
        {
            string selectQuery = "SELECT nombre FROM categoria";
            List<string> categorias = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader.GetString("nombre"));
                        }
                    }
                }
            }
            return categorias;
        }
        public static bool CheckCategoriaExistente(string nombre)
        {
            string selectQuery = "SELECT COUNT(*) FROM categoria WHERE nombre=@nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", nombre.Trim());
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (count > 0) return true;
                    else return false;
                }
            }
        }
    }
}
