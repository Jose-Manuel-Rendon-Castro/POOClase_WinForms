﻿using POOClase_WinForms.Controladores;
using POOClase_WinForms.Modelos;
using POOClase_WinForms.Vistas;

namespace POOClase_WinForms
{
    public partial class FrmMenu : Form
    {
        private MenuControlador _menuControlador;
        private FrmLogin _frmLogin;
        public FrmMenu(Usuario usuario)
        {
            InitializeComponent();
            _menuControlador = new MenuControlador(this);
        }        
    }
}
