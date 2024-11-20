using MySql.Data.MySqlClient;
using POOClase_WinForms.DataAccessObject.ModelosDAO;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.AccessData
{
    public class AgregarCategoriaDAO : ConnectionString
    {
        public static void AgregarCategoria(string nombre, string precio_minimo)
        {
            string insertQuery = "INSERT INTO categoria (nombre, precio_minimo) VALUES (@nombre, @precio_minimo)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn))
                {
                    insertCommand.Parameters.AddWithValue("@nombre", nombre);
                    insertCommand.Parameters.AddWithValue("@precio_minimo", precio_minimo);
                    if (!CategoriaDAO.CheckCategoriaExistente(nombre))
                    {
                        insertCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }        
    }
}
