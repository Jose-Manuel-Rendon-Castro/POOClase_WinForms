using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmLogin : Form
    {
        private LoginControlador _loginControlador;
        public FrmLogin()
        {
            InitializeComponent();
            _loginControlador = new LoginControlador(this);
        }       
    }
}
