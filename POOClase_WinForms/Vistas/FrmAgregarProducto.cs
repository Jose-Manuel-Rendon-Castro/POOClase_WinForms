using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmAgregarProducto : Form
    {
        private AgregarProductoControllador _agregarProductoControllador;
        public FrmAgregarProducto()
        {           
            InitializeComponent();
            _agregarProductoControllador = new AgregarProductoControllador(this);
        }              
    }
}
