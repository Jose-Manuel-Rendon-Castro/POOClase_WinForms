using POOClase_WinForms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOClase_WinForms
{
    public partial class FrmMenu : Form
    {
        private List<Producto> listaProductos;
        public FrmMenu(Usuario usuario, List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            lblMenu_Bienvenido.Text = $"Bienvenido {usuario.GetUsername()}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregarProducto = new FrmAgregarProducto(listaProductos);
            frmAgregarProducto.ShowDialog();
        }

        private void btnMenu_Buscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frmBuscarProducto = new FrmBuscarProducto(listaProductos);
            frmBuscarProducto.ShowDialog();
        }
    }
}
