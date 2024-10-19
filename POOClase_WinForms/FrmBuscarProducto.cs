using POOClase_WinForms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOClase_WinForms
{
    public partial class FrmBuscarProducto : Form
    {
        private Producto producto = new Producto();
        private List<Producto> listaProductos;
        public FrmBuscarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txtBBuscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                producto.CheckProductInfo(txtBBuscar.Text, listaProductos, label1);
            }
        }

        private void btnBuscar_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
