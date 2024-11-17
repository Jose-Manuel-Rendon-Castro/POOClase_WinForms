
namespace POOClase_WinForms
{
    partial class FrmAgregarProducto
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
            lblAgregarProducto_Nombre = new Label();
            lblAgregarProducto_Precio = new Label();
            lblAgregarProducto_Categoria = new Label();
            txtBAgregarProducto_Nombre = new TextBox();
            btnAgregarProducto_Agregar = new Button();
            txtBAgregarProducto_Precio = new TextBox();
            lblAgregarProducto_PrecioMinimo = new Label();
            combxCategoriasDisponibles = new ComboBox();
            SuspendLayout();
            // 
            // lblAgregarProducto_Nombre
            // 
            lblAgregarProducto_Nombre.AutoSize = true;
            lblAgregarProducto_Nombre.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Nombre.Location = new Point(10, 67);
            lblAgregarProducto_Nombre.Name = "lblAgregarProducto_Nombre";
            lblAgregarProducto_Nombre.Size = new Size(212, 25);
            lblAgregarProducto_Nombre.TabIndex = 0;
            lblAgregarProducto_Nombre.Text = "Nombre de producto:";
            // 
            // lblAgregarProducto_Precio
            // 
            lblAgregarProducto_Precio.Anchor = AnchorStyles.Right;
            lblAgregarProducto_Precio.AutoSize = true;
            lblAgregarProducto_Precio.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Precio.Location = new Point(148, 148);
            lblAgregarProducto_Precio.Name = "lblAgregarProducto_Precio";
            lblAgregarProducto_Precio.Size = new Size(82, 25);
            lblAgregarProducto_Precio.TabIndex = 1;
            lblAgregarProducto_Precio.Text = "Precio: ";
            // 
            // lblAgregarProducto_Categoria
            // 
            lblAgregarProducto_Categoria.AutoSize = true;
            lblAgregarProducto_Categoria.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Categoria.Location = new Point(120, 242);
            lblAgregarProducto_Categoria.Name = "lblAgregarProducto_Categoria";
            lblAgregarProducto_Categoria.Size = new Size(108, 25);
            lblAgregarProducto_Categoria.TabIndex = 3;
            lblAgregarProducto_Categoria.Text = "Categoría:";
            // 
            // txtBAgregarProducto_Nombre
            // 
            txtBAgregarProducto_Nombre.BackColor = Color.Snow;
            txtBAgregarProducto_Nombre.Location = new Point(237, 71);
            txtBAgregarProducto_Nombre.Margin = new Padding(3, 2, 3, 2);
            txtBAgregarProducto_Nombre.Name = "txtBAgregarProducto_Nombre";
            txtBAgregarProducto_Nombre.Size = new Size(260, 23);
            txtBAgregarProducto_Nombre.TabIndex = 4;
            txtBAgregarProducto_Nombre.UseWaitCursor = true;
            // 
            // btnAgregarProducto_Agregar
            // 
            btnAgregarProducto_Agregar.BackColor = SystemColors.ActiveCaption;
            btnAgregarProducto_Agregar.Location = new Point(528, 126);
            btnAgregarProducto_Agregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto_Agregar.Name = "btnAgregarProducto_Agregar";
            btnAgregarProducto_Agregar.Size = new Size(161, 72);
            btnAgregarProducto_Agregar.TabIndex = 8;
            btnAgregarProducto_Agregar.Text = "Agregar";
            btnAgregarProducto_Agregar.UseVisualStyleBackColor = false;
            // 
            // txtBAgregarProducto_Precio
            // 
            txtBAgregarProducto_Precio.BackColor = Color.Snow;
            txtBAgregarProducto_Precio.Location = new Point(237, 152);
            txtBAgregarProducto_Precio.Margin = new Padding(3, 2, 3, 2);
            txtBAgregarProducto_Precio.Name = "txtBAgregarProducto_Precio";
            txtBAgregarProducto_Precio.Size = new Size(260, 23);
            txtBAgregarProducto_Precio.TabIndex = 5;
            txtBAgregarProducto_Precio.UseWaitCursor = true;
            // 
            // lblAgregarProducto_PrecioMinimo
            // 
            lblAgregarProducto_PrecioMinimo.AutoSize = true;
            lblAgregarProducto_PrecioMinimo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgregarProducto_PrecioMinimo.Location = new Point(237, 183);
            lblAgregarProducto_PrecioMinimo.Name = "lblAgregarProducto_PrecioMinimo";
            lblAgregarProducto_PrecioMinimo.Size = new Size(125, 21);
            lblAgregarProducto_PrecioMinimo.TabIndex = 9;
            lblAgregarProducto_PrecioMinimo.Text = "Precio Mínimo:";
            // 
            // combxCategoriasDisponibles
            // 
            combxCategoriasDisponibles.FormattingEnabled = true;
            combxCategoriasDisponibles.Location = new Point(237, 247);
            combxCategoriasDisponibles.Name = "combxCategoriasDisponibles";
            combxCategoriasDisponibles.Size = new Size(173, 23);
            combxCategoriasDisponibles.TabIndex = 10;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(700, 338);
            Controls.Add(combxCategoriasDisponibles);
            Controls.Add(lblAgregarProducto_PrecioMinimo);
            Controls.Add(btnAgregarProducto_Agregar);
            Controls.Add(txtBAgregarProducto_Precio);
            Controls.Add(txtBAgregarProducto_Nombre);
            Controls.Add(lblAgregarProducto_Categoria);
            Controls.Add(lblAgregarProducto_Precio);
            Controls.Add(lblAgregarProducto_Nombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAgregarProducto";
            Text = "FrmAgregarProducto";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgregarProducto_Nombre;
        private Label lblAgregarProducto_Precio;
        private Label lblAgregarProducto_Categoria;
        public TextBox txtBAgregarProducto_Nombre;
        public Button btnAgregarProducto_Agregar;
        public TextBox txtBAgregarProducto_Precio;
        public Label lblAgregarProducto_PrecioMinimo;
        public ComboBox combxCategoriasDisponibles;
    }
}