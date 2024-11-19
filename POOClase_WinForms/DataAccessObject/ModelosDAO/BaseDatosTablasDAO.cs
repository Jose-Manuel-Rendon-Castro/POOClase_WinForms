using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;

namespace POOClase_WinForms.DataAccessObject.ModelosDAO
{
    public class BaseDatosTablasDAO : ConnectionString
    {
        public static List<string> ObtenerTablas()
        {
            string selectQuery = "SELECT TABLE_NAME FROM information_schema.VIEWS WHERE TABLE_SCHEMA = 'tienda'";
            List<string> tablas = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablas.Add(reader.GetString("TABLE_NAME"));
                        }
                    }
                }
            }
            return tablas;
        }
    }
}
