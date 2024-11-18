using POOClase_WinForms.Controladores;

namespace POOClase_WinForms.Vistas.Vistas_Administrador
{
    public partial class FrmTablasInfo : Form
    {
        private TablasInfoControlador _tablasInfoControlador;
        public FrmTablasInfo()
        {
            InitializeComponent();
            _tablasInfoControlador = new TablasInfoControlador(this);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
