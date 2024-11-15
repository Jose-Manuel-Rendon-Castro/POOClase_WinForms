using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using System.Data;

namespace POOClase_WinForms.DataAccessObject
{
    public class TablasInfoDAO : ConnectionString
    {
        public static void MostrarInfo(DataGridView tableInfo, string nombreTabla)
        {
            string selectQuery = $"SELECT * FROM {nombreTabla}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataTable.Load(reader);
                            tableInfo.DataSource = dataTable; 
                        }
                    }
                }
            }
        }
    }
}
