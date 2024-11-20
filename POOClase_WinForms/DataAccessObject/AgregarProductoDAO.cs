using MySql.Data.MySqlClient;
using POOClase_WinForms.DataAccessObject.ModelosDAO;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.AccessData
{
    public class AgregarProductoDAO : ConnectionString
    {
        public static void AgregarProducto(string nombre, string precio, string producto_categoria)
        {
            string insertQuery = "INSERT INTO producto (id, nombre, precio, categoria, existencias) VALUES (@id, @nombre, @precio, @producto_categoria, 0)";
            string selectQuery = "SELECT id FROM categoria WHERE nombre = @nombre";

            string full_id;
            Producto producto = new Producto();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", producto_categoria);
                    string categoria_id = (string)selectCommand.ExecuteScalar();

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@nombre", nombre);
                        insertCommand.Parameters.AddWithValue("@precio", precio);
                        insertCommand.Parameters.AddWithValue("@producto_categoria", categoria_id);

                        if (CategoriaDAO.CheckCategoriaExistente(producto_categoria))
                        {
                            if (CategoriaDAO.CheckIfHigherMinimumPrice(precio, producto_categoria))
                            {
                                full_id = categoria_id + ProductoDAO.GetID(producto_categoria);
                                insertCommand.Parameters.AddWithValue("@id", full_id);
                                insertCommand.ExecuteNonQuery();
                                producto = (Producto)ProductoDAO.GetObjectProducto(nombre);
                                MessageBox.Show($"Se ha agregado el producto.\nID: {producto.id}\nNombre: {producto.nombre}\nCategoria: {producto.categoria} ({producto_categoria})\nPrecio: ${producto.precio}\nCodigo de barra: {producto.codigoBarra}");
                            }
                        }
                    }
                }
            }
        }
    }
}
