using POOClase_WinForms.Controladores;

namespace POOClase_WinForms.Vistas
{
    public partial class FrmAgregarCategoria : Form
    {
        private AgregarCategoriaControlador _agregarCategoriaControlador;
        public FrmAgregarCategoria()
        {
            InitializeComponent();
            _agregarCategoriaControlador = new AgregarCategoriaControlador(this);
        }
    }
}
