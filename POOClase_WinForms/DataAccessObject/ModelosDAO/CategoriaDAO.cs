using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;

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
    }
}
