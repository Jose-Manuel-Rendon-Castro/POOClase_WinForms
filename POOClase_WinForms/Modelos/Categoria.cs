using POOClase_WinForms.Vistas;
using MySql.Data.MySqlClient;

namespace POOClase_WinForms.Modelos
{
    public class Categoria
    {
        private int _id;
        private string _name;
        private decimal _precio_Minimo;

        public int id { get { return _id; } set { _id = value; } }
        public string name { get { return _name; } set { _name = value; } }        
        public decimal precio_Minimo { get { return _precio_Minimo; } set { _precio_Minimo = value; } }
    }
}
