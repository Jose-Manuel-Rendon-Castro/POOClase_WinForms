using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using System.Data;

namespace POOClase_WinForms.DataAccessObject
{
    public class TablasInfoDAO : ConnectionString
    {
        public static void MostrarTabla(DataGridView dataGridView, string nombreTabla, string id, string nombreElemento, string nombreCategoria, string precioDe, string precioHasta)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(FiltradoDatos(nombreTabla, id, nombreElemento, nombreCategoria, precioDe, precioHasta), conn))
                {
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataTable.Load(reader);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }

        }

        private static string FiltradoDatos(string nombreTabla, string id, string nombreElemento, string nombreCategoria, string precioDe, string precioHasta)
        {
            string selectQuery = $"SELECT * FROM {nombreTabla}";
            List<string> condiciones = new List<string>();

            if (!string.IsNullOrEmpty(id))
            {
                if (int.TryParse(id, out int ID))
                {
                    condiciones.Add($"ID = {ID}");
                }
                else { return selectQuery; }
            }
            if (!string.IsNullOrEmpty(nombreCategoria))
            {
                condiciones.Add($"Nombre_Categoria LIKE '%{nombreCategoria}%'");
            }
            if (!string.IsNullOrEmpty(nombreElemento))
            {
                condiciones.Add($"Nombre LIKE '%{nombreElemento}%'");
            }
            if (!string.IsNullOrEmpty(precioDe) && !string.IsNullOrEmpty(precioHasta))
            {
                if (decimal.TryParse(precioDe, out decimal numPrecioDe) && decimal.TryParse(precioHasta, out decimal numPrecioHasta))
                {
                    if (numPrecioHasta < numPrecioDe) { return selectQuery; }
                    else
                    {
                        if (nombreTabla != "categorias")
                        {
                            condiciones.Add($"Precio BETWEEN {numPrecioDe} AND {numPrecioHasta}");
                        }
                        else
                        {
                            condiciones.Add($"Precio_Minimo BETWEEN {numPrecioDe} AND {numPrecioHasta}");
                        }
                    }
                }
            }
            if (condiciones.Count > 0)
            {
                selectQuery += " WHERE " + String.Join(" AND ", condiciones);
                return selectQuery;
            }
            else
            {
                return selectQuery;
            }
        }
    }
}
