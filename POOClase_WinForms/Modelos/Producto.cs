using System.Linq.Expressions;

namespace POOClase_WinForms.Modelos
{
    public class Producto
    {
        private int _id;
        private int _categoria;
        private String _nombre;
        private decimal _precio;
        private long _codigoBarra;
        private int _existencias;

        public int id { get { return _id; } set { _id = value; } }
        public int categoria { get { return _categoria; } set { _categoria = value; } }
        public String nombre { get { return _nombre; } set { _nombre = value; } }
        public decimal precio { get { return _precio; } set { _precio = value; } }        
        public long codigoBarra { get { return _codigoBarra; } set { _codigoBarra = value; } }
        public int existencias { get { return _existencias; } set { _existencias = value; } }
        
        public static List<Producto> _listaProductos = new List<Producto>();
    }
}
