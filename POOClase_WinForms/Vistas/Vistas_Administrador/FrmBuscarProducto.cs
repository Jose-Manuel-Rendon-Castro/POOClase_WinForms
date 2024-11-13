using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmBuscarProducto : Form
    {
        private Producto producto = new Producto();
        private BuscarProductoControlador _buscarProductoControlador;
        public FrmBuscarProducto()
        {
            InitializeComponent();
            _buscarProductoControlador = new BuscarProductoControlador(this);
        }        
    }
}
