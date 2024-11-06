using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;
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
        private BuscarProductoControlador _buscarProductoControlador;
        public FrmBuscarProducto()
        {
            InitializeComponent();
            _buscarProductoControlador = new BuscarProductoControlador(this);
        }        
    }
}
