using MySql.Data.MySqlClient;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.AccessData
{
    public class BuscarCategoriaDAO
    {
        private static readonly string connectionString = "Server=localhost;Database=tienda;Uid=root;Pwd=23040273";

        public static Categoria? BuscarCategoria(FrmBuscarCategoria frmBuscarCategoria)
        {
            string selectQuery = "SELECT * FROM categoria WHERE id = @id";

            if (!int.TryParse(frmBuscarCategoria.txtBBuscarCategoria.Text.Trim(), out int input_id))
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
                        if (reader.Read())
                        {
                            Categoria categoria = new Categoria
                            {
                                id = reader.GetInt32("id"),
                                nombre = reader.GetString("nombre"),
                                precio_Minimo = reader.GetDecimal("precio_minimo")
                            };
                            return categoria;
                        }
                        else { return null; }
                    }
                }
            }
        }
    }
}
