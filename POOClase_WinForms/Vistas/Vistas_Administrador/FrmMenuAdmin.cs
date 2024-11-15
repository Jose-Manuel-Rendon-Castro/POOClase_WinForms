using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmMenuAdmin : Form
    {
        private MenuControlador _menuControlador;
        public FrmMenuAdmin(Usuario usuario)
        {
            InitializeComponent();
            _menuControlador = new MenuControlador(this);
        }        
    }
}
