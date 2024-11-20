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

        public static bool CheckIfHigherMinimumPrice(string precio, string nombre_categoria)
        {
            string selectQuery = "SELECT precio_minimo FROM categoria WHERE nombre = @nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", nombre_categoria);
                    decimal result = Convert.ToDecimal(selectCommand.ExecuteScalar());
                    if (Convert.ToDecimal(precio) >= result)
                    {
                        return true;
                    }
                    else return false;                   
                }
            }
        }
        public static decimal ObtenerPrecioMinimoPorCategoria(string nombreCategoria)
        {
            string selectQuery = "SELECT precio_minimo FROM categoria WHERE nombre = @nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", nombreCategoria);

                    object result = selectCommand.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out decimal precioMinimo))
                    {
                        return precioMinimo;
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener el precio mínimo para la categoría seleccionada.");
                    }
                }
            }
        }
    }
}
