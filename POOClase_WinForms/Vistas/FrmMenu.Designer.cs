namespace POOClase_WinForms
{
    partial class FrmMenu
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
            btnAgregarProducto = new Button();
            btnMenu_Buscar = new Button();
            btnMenu_cerrarSesion = new Button();
            btnMenu_agregarCategoria = new Button();
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
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.ActiveCaption;
            btnAgregarProducto.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.Location = new Point(12, 70);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(283, 68);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnMenu_Buscar
            // 
            btnMenu_Buscar.BackColor = SystemColors.ActiveCaption;
            btnMenu_Buscar.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_Buscar.Location = new Point(12, 155);
            btnMenu_Buscar.Name = "btnMenu_Buscar";
            btnMenu_Buscar.Size = new Size(283, 68);
            btnMenu_Buscar.TabIndex = 2;
            btnMenu_Buscar.Text = "Buscar info de producto";
            btnMenu_Buscar.UseVisualStyleBackColor = false;
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
            // btnMenu_agregarCategoria
            // 
            btnMenu_agregarCategoria.BackColor = SystemColors.ActiveCaption;
            btnMenu_agregarCategoria.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_agregarCategoria.Location = new Point(12, 244);
            btnMenu_agregarCategoria.Name = "btnMenu_agregarCategoria";
            btnMenu_agregarCategoria.Size = new Size(283, 68);
            btnMenu_agregarCategoria.TabIndex = 4;
            btnMenu_agregarCategoria.Text = "Agregar categoría";
            btnMenu_agregarCategoria.UseVisualStyleBackColor = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu_agregarCategoria);
            Controls.Add(btnMenu_cerrarSesion);
            Controls.Add(btnMenu_Buscar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblMenu_Bienvenido);
            Name = "FrmMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblMenu_Bienvenido;
        public Button btnAgregarProducto;
        public Button btnMenu_Buscar;
        public Button btnMenu_cerrarSesion;
        public Button btnMenu_agregarCategoria;
    }
}