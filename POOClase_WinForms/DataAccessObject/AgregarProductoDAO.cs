using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace POOClase_WinForms.AccessData
{
    public class AgregarProductoDAO : ConnectionString
    {
        public static void AgregarPrducto(FrmAgregarProducto _frmAgregarProducto)
        {
            string insertQuery = "INSERT INTO producto (id, nombre, precio, categoria, existencias) VALUES (@id, @nombre, @precio, @producto_categoria, 0)";
            string selectQuery = "SELECT id FROM categoria WHERE nombre = @nombre";

            string input_nombre = _frmAgregarProducto.txtBAgregarProducto_Nombre.Text;
            decimal input_precio = Convert.ToDecimal(_frmAgregarProducto.txtBAgregarProducto_Precio.Text);
            string? input_categoria = _frmAgregarProducto?.combxCategoriasDisponibles.SelectedItem?.ToString(); // Nuevo: obtenemos el valor del ComboBox.
            string full_id;
            Producto producto = new Producto();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", input_categoria);
                    int categoria_id = (int)selectCommand.ExecuteScalar();

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@nombre", input_nombre);
                        insertCommand.Parameters.AddWithValue("@precio", input_precio);
                        insertCommand.Parameters.AddWithValue("@producto_categoria", categoria_id);

                        if (CheckIfCategory(_frmAgregarProducto, input_categoria))
                        {
                            if (CheckIfHigherMinimumPrice(_frmAgregarProducto, input_categoria))
                            {
                                full_id = categoria_id.ToString() + GetID(_frmAgregarProducto, input_categoria).ToString();
                                insertCommand.Parameters.AddWithValue("@id", Convert.ToInt32(full_id));
                                insertCommand.ExecuteNonQuery();
                                producto = (Producto)GetObjectProducto(_frmAgregarProducto, input_nombre);
                                MessageBox.Show($"Se ha agregado el producto.\nID: {producto.id}\nNombre: {producto.nombre}\nCategoria: {producto.categoria} ({input_categoria})\nPrecio: ${producto.precio}\nCodigo de barra: {producto.codigoBarra}");
                            }
                            else
                            {
                                MessageBox.Show("Precio por debajo del precio mínimo de la categoría.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Categoría inexistente.");
                            return;
                        }
                    }
                }
            }
        }
        private static bool CheckIfCategory(FrmAgregarProducto? _frmAgregarProducto, string? input_nombreCategoria)
        {
            string selectQuery = "SELECT COUNT(*) FROM categoria WHERE nombre = @nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", input_nombreCategoria);
                    int result = Convert.ToInt32(selectCommand.ExecuteScalar());
                    if (result > 0) return true;
                    else return false;
                }
            }            
        }
        private static bool CheckIfHigherMinimumPrice(FrmAgregarProducto? _frmAgregarProducto, string? input_nombreCategoria)
        {
            string selectQuery = "SELECT precio_minimo FROM categoria WHERE nombre = @nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    if (CheckIfCategory(_frmAgregarProducto, input_nombreCategoria))
                    {
                        selectCommand.Parameters.AddWithValue("@nombre", input_nombreCategoria);
                        decimal result = Convert.ToDecimal(selectCommand.ExecuteScalar());
                        if (Convert.ToDecimal(_frmAgregarProducto.txtBAgregarProducto_Precio.Text) >= result)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
            }
        }
        private static object? GetObjectProducto(FrmAgregarProducto _frmAgregarProducto, string input_nombreProducto)
        {
            string selectQuery = "SELECT * FROM producto WHERE nombre = @nombre";            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", input_nombreProducto.Trim());
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
        private static int GetID(FrmAgregarProducto? _frmAgregarProducto, string? input_nombreCategoria)
        {
            string getNumberQuery = "SELECT COUNT(*) FROM producto p JOIN categoria c ON p.categoria = c.id WHERE c.nombre = @nombre GROUP BY p.categoria;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand getNumberCommand = new MySqlCommand(getNumberQuery, conn))
                {
                    getNumberCommand.Parameters.AddWithValue("@nombre", input_nombreCategoria.Trim());
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
