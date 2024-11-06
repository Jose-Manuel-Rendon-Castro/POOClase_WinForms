using MySql.Data.MySqlClient;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.AccessData
{
    public class CategoriaDAO
    {
        private static readonly string connectionString = "Server=localhost;Database=tienda;Uid=root;Pwd=23040273";
        public void AgregarCategoria(FrmAgregarCategoria _frmAgregarCategoria)
        {
            string insertQuery = "INSERT INTO categoria (nombre, precio_minimo) VALUES (@nombre, @precio_minimo)";

            string input_Nombre = _frmAgregarCategoria.txtBNombreCategoria.Text;
            decimal input_Precio = decimal.Parse(_frmAgregarCategoria.txtBPrecioMinimo.Text);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@nombre", input_Nombre);
                    insertCommand.Parameters.AddWithValue("@precio_minimo", input_Precio);
                    if (!CheckCategoriaExistente(_frmAgregarCategoria))
                    {
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show($"Se ha agregado la categoria {input_Nombre}");
                    }
                    else
                    {
                        MessageBox.Show("Esta categoría ya existe. No se va a guardar");
                    }
                }
            }
        }

        public bool CheckCategoriaExistente(FrmAgregarCategoria _frmAgregarCategoria)
        {
            string selectQuery = "SELECT COUNT(*) FROM categoria WHERE nombre=@nombre";
            string input_Nombre = _frmAgregarCategoria.txtBNombreCategoria.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    selectCommand.Parameters.AddWithValue("@nombre", input_Nombre.Trim());
                    int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                    if (count > 0) return true;
                    else return false;
                }
            }
        }
    }
}
