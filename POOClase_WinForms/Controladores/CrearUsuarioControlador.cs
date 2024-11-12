using POOClase_WinForms.AccessData;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms.Controladores
{
    public class CrearUsuarioControlador
    {
        private FrmCrearUsuario _frmCrearUsuario;
        public CrearUsuarioControlador(FrmCrearUsuario frmCrearUsuario)
        {
            _frmCrearUsuario = frmCrearUsuario;
            _frmCrearUsuario.btnCrearUsuario_Crear.Click += btnCrearUsuario_Crear_Click;
        }

        private void btnCrearUsuario_Crear_Click(object sender, EventArgs e)
        {
            if (!Usuario.CheckTxtBox(_frmCrearUsuario))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Usuario.ConfirmarContraseña(_frmCrearUsuario))
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique e intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!CrearUsuarioDAO.CrearUsuario
            (
                _frmCrearUsuario.txtbCrearUsuario_NombreUsuario.Text,
                _frmCrearUsuario.txtbCrearUsuario_Contraseña.Text,
                _frmCrearUsuario.txtbCrearUsuario_Nombre.Text,
                _frmCrearUsuario.txtbCrearUsuario_Apellido.Text,
                _frmCrearUsuario.txtbCrearUsuario_Email.Text,
                _frmCrearUsuario.combxCrearUsuario_Tipo.Text
            ))
            {
                return;
            }           
            _frmCrearUsuario.Close();
        }
    }
}
