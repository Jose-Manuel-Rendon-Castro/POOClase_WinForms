using MySql.Data.MySqlClient;
using POOClase_WinForms.AccessData;
using System.Data;

namespace POOClase_WinForms.DataAccessObject
{
    public class TablasInfoDAO : ConnectionString
    {
        public static void MostrarTabla(DataGridView dataGridView, string nombreTabla, string id, string nombreElemento, string nombreCategoria,
            string precioDe, string precioHasta, string existenciasCondicion, string existenciasValor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand selectCommand = new MySqlCommand(FiltradoDatos(nombreTabla, id, nombreElemento, nombreCategoria, precioDe, precioHasta,
                    existenciasCondicion, existenciasValor), conn))
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

        private static string FiltradoDatos(string nombreTabla, string id, string nombreElemento, string nombreCategoria, string precioDe, string precioHasta,
            string existenciasCondicion, string existenciasValor)
        {
            string selectQuery = $"SELECT * FROM {nombreTabla}";
            List<string> condiciones = new List<string>();

            if (!string.IsNullOrEmpty(id)) { condiciones.Add($"ID = {id}"); }

            if (!string.IsNullOrEmpty(nombreCategoria)) { condiciones.Add($"Nombre_Categoria LIKE '%{nombreCategoria}%'"); }

            if (!string.IsNullOrEmpty(nombreElemento)) { condiciones.Add($"Nombre LIKE '%{nombreElemento}%'"); }

            if (!string.IsNullOrEmpty(precioDe) && !string.IsNullOrEmpty(precioHasta))
            {
                if (nombreTabla != "categorias")
                {
                    condiciones.Add($"Precio BETWEEN {precioDe} AND {precioHasta}");
                }
                else
                {
                    condiciones.Add($"Precio_Minimo BETWEEN {precioDe}  AND  {precioHasta}");
                }
            }

            if (!string.IsNullOrEmpty(existenciasCondicion) && !string.IsNullOrEmpty(existenciasValor)) 
                { condiciones.Add($"Existencias {existenciasCondicion} {existenciasValor}"); }

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
