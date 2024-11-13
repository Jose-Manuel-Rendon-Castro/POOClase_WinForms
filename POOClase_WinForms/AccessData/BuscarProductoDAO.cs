using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.AccessData
{
    public class BuscarProductoDAO : ConnectionString
    {
        public static Producto? BuscarProdutoInfo(FrmBuscarProducto frmBuscarProducto)
        {
            string selectQuery = "SELECT * FROM producto WHERE id = @id";

            if(!int.TryParse(frmBuscarProducto.txtBBuscar.Text.Trim(), out int input_id))
            {
                return null;
            }
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@id", input_id);
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                id = reader.GetInt32("id"),
                                categoria = reader.GetInt32("categoria"),
                                nombre = reader.GetString("nombre"),
                                precio = reader.GetDecimal("precio"),
                                codigoBarra = reader.GetInt32("codigo_barra"),
                                existencias = reader.GetInt32("existencias")
                            };
                            return producto;
                        }
                        else { return null; }
                    }
                }
            }
        }
    }
}
