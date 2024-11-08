using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;
using System.Diagnostics.Eventing.Reader;

namespace POOClase_WinForms.AccessData
{
    public class ProductoDAO
    {
        private static readonly string connectionString = "Server=localhost;Database=tienda;Uid=root;Pwd=23040273";

        public static void AgregarPrducto(FrmAgregarProducto _frmAgregarProducto)
        {
            string insertQuery = "INSERT INTO producto (id, nombre, precio, categoria) VALUES (@id, @nombre, @precio, @producto.categoria)";
            string selectQuery = "SELECT id FROM categoria WHERE categoria.nombre = @categoria.nombre";

            string input_nombre = _frmAgregarProducto.txtBAgregarProducto_Nombre.Text;
            decimal input_precio = Convert.ToDecimal(_frmAgregarProducto.txtBAgregarProducto_Precio.Text);
            string input_categoria = _frmAgregarProducto.txtBAgregarProducto_Categoria.Text;
            string full_id;
            Producto producto = new Producto();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@categoria.nombre", input_categoria);
                    int categoria_id = (int)selectCommand.ExecuteScalar();

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                    
                        insertCommand.Parameters.AddWithValue("@nombre", input_nombre);
                        insertCommand.Parameters.AddWithValue("@precio", input_precio);
                        insertCommand.Parameters.AddWithValue("@producto.categoria", categoria_id);
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
                                MessageBox.Show("Precio por debajo del precio minimo de la categoria");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Categoria inexisente");
                            return;
                        }
                    }
                }
            }
        }

        private static bool CheckIfCategory(FrmAgregarProducto _frmAgregarProducto, string input_nombreCategoria)
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
        private static bool CheckIfHigherMinimumPrice(FrmAgregarProducto _frmAgregarProducto, string input_nombreCategoria)
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
        private static object GetObjectProducto(FrmAgregarProducto _frmAgregarProducto, string input_nombreProducto)
        {
            string selectQuery = "SELECT * FROM producto WHERE nombre = @nombre";
            string input_nombre = input_nombreProducto.Trim();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", input_nombre);
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
        private static int GetID(FrmAgregarProducto _frmAgregarProducto, string input_nombreCategoria)
        {
            string getNumberQuery = "SELECT COUNT(*) FROM producto p JOIN categoria c ON p.categoria = c.id WHERE c.nombre = @nombre GROUP BY p.categoria;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                using (MySqlCommand getNumberCommand = new MySqlCommand(getNumberQuery, conn))
                {
                    getNumberCommand.Parameters.AddWithValue("@nombre", input_nombreCategoria.Trim());
                    if(getNumberCommand.ExecuteScalar() == null)
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
    }
}
