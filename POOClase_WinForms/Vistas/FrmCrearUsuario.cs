using POOClase_WinForms.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOClase_WinForms.Vistas
{
    public partial class FrmCrearUsuario : Form
    {
        private CrearUsuarioControlador _crearUsuarioControlador;
        public FrmCrearUsuario()
        {
            InitializeComponent();
            _crearUsuarioControlador = new CrearUsuarioControlador(this);
        }
    }
}
