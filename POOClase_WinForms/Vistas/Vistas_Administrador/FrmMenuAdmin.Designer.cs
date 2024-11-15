namespace POOClase_WinForms
{
    partial class FrmMenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMenu_Bienvenido = new Label();
            btnMenu_AgregarProducto = new Button();
            btnMenu_BuscarProducto = new Button();
            btnMenu_cerrarSesion = new Button();
            btnMenu_AgregarCategoria = new Button();
            btnMenu_BuscarCategoria = new Button();
            btnMenu_CrearUsuario = new Button();
            btnMenu_VerTablasInfo = new Button();
            SuspendLayout();
            // 
            // lblMenu_Bienvenido
            // 
            lblMenu_Bienvenido.AutoSize = true;
            lblMenu_Bienvenido.Font = new Font("Microsoft YaHei UI Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu_Bienvenido.Location = new Point(12, 9);
            lblMenu_Bienvenido.Name = "lblMenu_Bienvenido";
            lblMenu_Bienvenido.Size = new Size(74, 36);
            lblMenu_Bienvenido.TabIndex = 0;
            lblMenu_Bienvenido.Text = "label";
            // 
            // btnMenu_AgregarProducto
            // 
            btnMenu_AgregarProducto.BackColor = SystemColors.ActiveCaption;
            btnMenu_AgregarProducto.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_AgregarProducto.Location = new Point(12, 70);
            btnMenu_AgregarProducto.Name = "btnMenu_AgregarProducto";
            btnMenu_AgregarProducto.Size = new Size(283, 68);
            btnMenu_AgregarProducto.TabIndex = 1;
            btnMenu_AgregarProducto.Text = "Agregar Producto";
            btnMenu_AgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnMenu_BuscarProducto
            // 
            btnMenu_BuscarProducto.BackColor = SystemColors.ActiveCaption;
            btnMenu_BuscarProducto.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_BuscarProducto.Location = new Point(12, 155);
            btnMenu_BuscarProducto.Name = "btnMenu_BuscarProducto";
            btnMenu_BuscarProducto.Size = new Size(283, 68);
            btnMenu_BuscarProducto.TabIndex = 2;
            btnMenu_BuscarProducto.Text = "Buscar info de producto";
            btnMenu_BuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnMenu_cerrarSesion
            // 
            btnMenu_cerrarSesion.BackColor = Color.IndianRed;
            btnMenu_cerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_cerrarSesion.Location = new Point(590, 17);
            btnMenu_cerrarSesion.Name = "btnMenu_cerrarSesion";
            btnMenu_cerrarSesion.Size = new Size(198, 39);
            btnMenu_cerrarSesion.TabIndex = 3;
            btnMenu_cerrarSesion.Text = "Cerrar sesión";
            btnMenu_cerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnMenu_AgregarCategoria
            // 
            btnMenu_AgregarCategoria.BackColor = SystemColors.ActiveCaption;
            btnMenu_AgregarCategoria.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_AgregarCategoria.Location = new Point(12, 244);
            btnMenu_AgregarCategoria.Name = "btnMenu_AgregarCategoria";
            btnMenu_AgregarCategoria.Size = new Size(283, 68);
            btnMenu_AgregarCategoria.TabIndex = 4;
            btnMenu_AgregarCategoria.Text = "Agregar categoría";
            btnMenu_AgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnMenu_BuscarCategoria
            // 
            btnMenu_BuscarCategoria.BackColor = SystemColors.ActiveCaption;
            btnMenu_BuscarCategoria.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_BuscarCategoria.Location = new Point(12, 332);
            btnMenu_BuscarCategoria.Name = "btnMenu_BuscarCategoria";
            btnMenu_BuscarCategoria.Size = new Size(283, 68);
            btnMenu_BuscarCategoria.TabIndex = 5;
            btnMenu_BuscarCategoria.Text = "Buscar info de categoria";
            btnMenu_BuscarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnMenu_CrearUsuario
            // 
            btnMenu_CrearUsuario.BackColor = SystemColors.ActiveCaption;
            btnMenu_CrearUsuario.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_CrearUsuario.Location = new Point(505, 70);
            btnMenu_CrearUsuario.Name = "btnMenu_CrearUsuario";
            btnMenu_CrearUsuario.Size = new Size(283, 68);
            btnMenu_CrearUsuario.TabIndex = 6;
            btnMenu_CrearUsuario.Text = "Crear Usuario";
            btnMenu_CrearUsuario.UseVisualStyleBackColor = false;
            // 
            // btnMenu_VerTablasInfo
            // 
            btnMenu_VerTablasInfo.BackColor = SystemColors.ActiveCaption;
            btnMenu_VerTablasInfo.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_VerTablasInfo.Location = new Point(505, 155);
            btnMenu_VerTablasInfo.Name = "btnMenu_VerTablasInfo";
            btnMenu_VerTablasInfo.Size = new Size(283, 68);
            btnMenu_VerTablasInfo.TabIndex = 7;
            btnMenu_VerTablasInfo.Text = "Ver tablas";
            btnMenu_VerTablasInfo.UseVisualStyleBackColor = false;
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu_VerTablasInfo);
            Controls.Add(btnMenu_CrearUsuario);
            Controls.Add(btnMenu_BuscarCategoria);
            Controls.Add(btnMenu_AgregarCategoria);
            Controls.Add(btnMenu_cerrarSesion);
            Controls.Add(btnMenu_BuscarProducto);
            Controls.Add(btnMenu_AgregarProducto);
            Controls.Add(lblMenu_Bienvenido);
            Name = "FrmMenuAdmin";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblMenu_Bienvenido;
        public Button btnMenu_AgregarProducto;
        public Button btnMenu_BuscarProducto;
        public Button btnMenu_cerrarSesion;
        public Button btnMenu_AgregarCategoria;
        public Button btnMenu_BuscarCategoria;
        public Button btnMenu_CrearUsuario;
        public Button btnMenu_VerTablasInfo;
    }
}