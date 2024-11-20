using POOClase_WinForms.AccessData;
using POOClase_WinForms.DataAccessObject.ModelosDAO;
using POOClase_WinForms.Exceptions;

namespace POOClase_WinForms.Controladores
{
    public class AgregarProductoControllador
    {
        private FrmAgregarProducto _frmAgregarProducto;
        public AgregarProductoControllador(FrmAgregarProducto frmAgregarProducto)
        {
            _frmAgregarProducto = frmAgregarProducto;
            _frmAgregarProducto.btnAgregarProducto_Agregar.Click += btnAgregarProducto_Agregar_Click;
            _frmAgregarProducto.combxCategoriasDisponibles.SelectedIndexChanged += combxCategoriasDisponibles_SelectedIndexChanged;
            LlenarComboBoxCategorias();
        }
        private void btnAgregarProducto_Agregar_Click(object? sender, EventArgs? e)
        {
            try
            {
                if 
                (
                    string.IsNullOrEmpty(_frmAgregarProducto.txtBAgregarProducto_Nombre.Text) ||
                    string.IsNullOrEmpty(_frmAgregarProducto.txtBAgregarProducto_Precio.Text) ||
                    string.IsNullOrEmpty(_frmAgregarProducto.combxCategoriasDisponibles.Text))
                {
                    throw new EmptyFieldException();
                }

                if (!CategoriaDAO.CheckIfHigherMinimumPrice(_frmAgregarProducto.txtBAgregarProducto_Precio.Text, _frmAgregarProducto.combxCategoriasDisponibles.Text))
                {
                    throw new Exception("Precio por debajo del precio mínimo de la categoría.");
                }
                AgregarProductoDAO.AgregarProducto(
                    _frmAgregarProducto.txtBAgregarProducto_Nombre.Text,
                    _frmAgregarProducto.txtBAgregarProducto_Precio.Text,
                    _frmAgregarProducto.combxCategoriasDisponibles.Text);

                _frmAgregarProducto.Close();
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LlenarComboBoxCategorias()
        {
            try
            {
                var categorias = CategoriaDAO.ObtenerCategorias();
                _frmAgregarProducto.combxCategoriasDisponibles.Items.AddRange(categorias.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
        }
        private void combxCategoriasDisponibles_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            string? categoriaSeleccionada = _frmAgregarProducto.combxCategoriasDisponibles.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                decimal precioMinimo = CategoriaDAO.ObtenerPrecioMinimoPorCategoria(categoriaSeleccionada);
                _frmAgregarProducto.lblAgregarProducto_PrecioMinimo.Text = $"Precio mínimo: ${precioMinimo:F2}";
            }
            else
            {
                _frmAgregarProducto.lblAgregarProducto_PrecioMinimo.Text = string.Empty;
            }
        }
    }
}
