using POOClase_WinForms.AccessData;
using POOClase_WinForms.Modelos;

namespace POOClase_WinForms.Controladores
{
    public class AgregarProductoControllador
    {
        private FrmAgregarProducto _frmAgregarProducto;
        public AgregarProductoControllador(FrmAgregarProducto frmAgregarProducto)
        {
            _frmAgregarProducto = frmAgregarProducto;
            _frmAgregarProducto.btnAgregarProducto_Agregar.Click += btnAgregarProcuto_Agregar_Click;
            _frmAgregarProducto.combxCategoriasDisponibles.SelectedIndexChanged += combxCategoriasDisponibles_SelectedIndexChanged;
            LlenarComboBoxCategorias();
        }
        private void btnAgregarProcuto_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductoDAO.AgregarPrducto(_frmAgregarProducto);
            _frmAgregarProducto.Close();
        }
        private void LlenarComboBoxCategorias()
        {
            try
            {
                var categorias = AgregarProductoDAO.ObtenerCategorias();
                _frmAgregarProducto.combxCategoriasDisponibles.Items.AddRange(categorias.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
        }
        private void combxCategoriasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = _frmAgregarProducto.combxCategoriasDisponibles.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                decimal precioMinimo = AgregarProductoDAO.ObtenerPrecioMinimoPorCategoria(categoriaSeleccionada);
                _frmAgregarProducto.lblAgregarProducto_PrecioMinimo.Text = $"Precio mínimo: ${precioMinimo:F2}";
            }
            else
            {
                _frmAgregarProducto.lblAgregarProducto_PrecioMinimo.Text = string.Empty;
            }
        }
    }
}
