using System.Linq.Expressions;

namespace POOClase_WinForms.Clases
{
    public class Producto
    {
        private int _id;
        private String _nombre;
        private decimal _precio;
        private int _codigoBarra;
        private String _categoria;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }        
        public int codigoBarra
        {
            get { return _codigoBarra; }
            set { _codigoBarra = value; }
        }
        public String categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public void CheckProductInfo(String buscarId, List<Producto> listaProducto, Label label)
        {
            if(int.TryParse(buscarId, out int _buscarId))
            {
                Producto producto = listaProducto.Find(p => p.id == _buscarId);

                label.Text = $"ID: {producto.id}\nNombre de producto: {producto.nombre}\nPrecio: ${producto.precio}\nCódigo de barra: {producto.codigoBarra}\nCategoría: {producto.categoria}";
            }
        }
    }
}
