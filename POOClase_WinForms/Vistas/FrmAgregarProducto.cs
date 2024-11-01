﻿using POOClase_WinForms.Modelos;

namespace POOClase_WinForms
{
    public partial class FrmAgregarProducto : Form
    {
        private List<Producto> listaProductos;
        public FrmAgregarProducto(List<Producto> listaProductos)
        {           
            InitializeComponent();
            this.listaProductos = listaProductos;
        }

        private bool ValidarCapturaDatos()
        {
            if (txtBAgregarProducto_Nombre.Text == "") return false;
            if (txtBAgregarProducto_Categoria.Text == "") return false;
            if (int.TryParse(txtBAgregarProducto_Precio.Text, out int precio))
            {
                if (precio < 1) return false;
            }
            else MessageBox.Show("Solo numeros");
            if (long.TryParse(txtBAgregarProducto_Codigo.Text, out long codigoBarra))
            {
                if (codigoBarra < 1) return false;
            }
            else MessageBox.Show("Solo numeros");

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCapturaDatos())
            {
                MessageBox.Show("No se pudo capturar producto correctamente");
                return;
            }
            else
            {
                Producto producto = new Producto();

                producto.id = listaProductos.Count + 1;
                producto.nombre = txtBAgregarProducto_Nombre.Text;
                producto.precio = int.Parse(txtBAgregarProducto_Precio.Text);
                producto.codigoBarra = long.Parse(txtBAgregarProducto_Codigo.Text);
                producto.categoria = txtBAgregarProducto_Categoria.Text;

                listaProductos.Add(producto);

                MessageBox.Show($"Producto agregado :)\nTotal Productos: {listaProductos.Count}");

                this.Close();
            }
        }
    }
}
