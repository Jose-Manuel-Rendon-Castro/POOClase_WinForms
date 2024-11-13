using MySql.Data.MySqlClient;
using POOClase_WinForms.Controladores;

namespace POOClase_WinForms.Vistas
{
    public partial class FrmBuscarCategoria : Form
    {
        private BuscarCategoriaControlador _buscarCategoriaControlador;
        public FrmBuscarCategoria()
        {
            InitializeComponent();
            _buscarCategoriaControlador = new BuscarCategoriaControlador(this);
        }
    }
}
