using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.DataAccessObject.ModelosDAO
{
    public class ProductoDAO : ConnectionString
    {
        public static int GetID(string producto_categoria)
        {
            string getNumberQuery = "SELECT COUNT(*) FROM producto p JOIN categoria c ON p.categoria = c.id WHERE c.nombre = @nombre GROUP BY p.categoria;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand getNumberCommand = new MySqlCommand(getNumberQuery, conn))
                {
                    getNumberCommand.Parameters.AddWithValue("@nombre", producto_categoria.Trim());
                    if (getNumberCommand.ExecuteScalar() == null)
                    {
                        return 1;
                    }
                    else
                    {
                        return Convert.ToInt32(getNumberCommand.ExecuteScalar()) + 1;
                    }
                }
            }
        }
        public static object? GetObjectProducto(string nombre)
        {
            string selectQuery = "SELECT * FROM producto WHERE nombre = @nombre";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", nombre.Trim());
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                id = reader.GetInt32("id"),
                                nombre = reader.GetString("nombre"),
                                precio = reader.GetDecimal("precio"),
                                categoria = reader.GetInt32("categoria"),
                                codigoBarra = reader.GetInt32("codigo_barra")
                            };
                            return producto;
                        }
                        else return null;
                    }
                }
            }
        }
    }
}
