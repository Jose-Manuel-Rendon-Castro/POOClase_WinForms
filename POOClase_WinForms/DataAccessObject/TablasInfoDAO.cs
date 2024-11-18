using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using System.Data;

namespace POOClase_WinForms.DataAccessObject
{
    public class TablasInfoDAO : ConnectionString
    {
        public static void MostrarTabla(DataGridView dataGridView, string nombreTabla, string id, string nombreElemento, string nombreCategoria, string precioDe, string precioHasta)
        {
            string selectQuery = $"SELECT * FROM {nombreTabla}";
            List<string> condiciones = new List<string>();

            if (!string.IsNullOrEmpty(id))
            {
                if (int.TryParse(id, out int ID))
                {
                    condiciones.Add($"id = {ID}");
                }
                else { return; }
            }
            if (!string.IsNullOrEmpty(nombreCategoria))
            {
                condiciones.Add(""); 
            }
        }
    }
}
