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
            lblAgregarProducto_Codigo = new Label();
            lblAgregarProducto_Categoria = new Label();
            txtBAgregarProducto_Nombre = new TextBox();
            txtBAgregarProducto_Codigo = new TextBox();
            txtBAgregarProducto_Categoria = new TextBox();
            button1 = new Button();
            txtBAgregarProducto_Precio = new TextBox();
            SuspendLayout();
            // 
            // lblAgregarProducto_Nombre
            // 
            lblAgregarProducto_Nombre.AutoSize = true;
            lblAgregarProducto_Nombre.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Nombre.Location = new Point(11, 19);
            lblAgregarProducto_Nombre.Name = "lblAgregarProducto_Nombre";
            lblAgregarProducto_Nombre.Size = new Size(254, 31);
            lblAgregarProducto_Nombre.TabIndex = 0;
            lblAgregarProducto_Nombre.Text = "Nombre de producto:";
            // 
            // lblAgregarProducto_Precio
            // 
            lblAgregarProducto_Precio.Anchor = AnchorStyles.Right;
            lblAgregarProducto_Precio.AutoSize = true;
            lblAgregarProducto_Precio.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Precio.Location = new Point(169, 109);
            lblAgregarProducto_Precio.Name = "lblAgregarProducto_Precio";
            lblAgregarProducto_Precio.Size = new Size(96, 31);
            lblAgregarProducto_Precio.TabIndex = 1;
            lblAgregarProducto_Precio.Text = "Precio: ";
            // 
            // lblAgregarProducto_Codigo
            // 
            lblAgregarProducto_Codigo.AutoSize = true;
            lblAgregarProducto_Codigo.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Codigo.Location = new Point(64, 216);
            lblAgregarProducto_Codigo.Name = "lblAgregarProducto_Codigo";
            lblAgregarProducto_Codigo.Size = new Size(201, 31);
            lblAgregarProducto_Codigo.TabIndex = 2;
            lblAgregarProducto_Codigo.Text = "Código de barra:";
            lblAgregarProducto_Codigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAgregarProducto_Categoria
            // 
            lblAgregarProducto_Categoria.AutoSize = true;
            lblAgregarProducto_Categoria.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto_Categoria.Location = new Point(137, 323);
            lblAgregarProducto_Categoria.Name = "lblAgregarProducto_Categoria";
            lblAgregarProducto_Categoria.Size = new Size(128, 31);
            lblAgregarProducto_Categoria.TabIndex = 3;
            lblAgregarProducto_Categoria.Text = "Categoría:";
            // 
            // txtBAgregarProducto_Nombre
            // 
            txtBAgregarProducto_Nombre.BackColor = Color.White;
            txtBAgregarProducto_Nombre.Location = new Point(271, 23);
            txtBAgregarProducto_Nombre.Name = "txtBAgregarProducto_Nombre";
            txtBAgregarProducto_Nombre.Size = new Size(297, 27);
            txtBAgregarProducto_Nombre.TabIndex = 4;
            txtBAgregarProducto_Nombre.UseWaitCursor = true;
            // 
            // txtBAgregarProducto_Codigo
            // 
            txtBAgregarProducto_Codigo.BackColor = Color.White;
            txtBAgregarProducto_Codigo.Location = new Point(271, 216);
            txtBAgregarProducto_Codigo.Name = "txtBAgregarProducto_Codigo";
            txtBAgregarProducto_Codigo.Size = new Size(297, 27);
            txtBAgregarProducto_Codigo.TabIndex = 6;
            txtBAgregarProducto_Codigo.UseWaitCursor = true;
            // 
            // txtBAgregarProducto_Categoria
            // 
            txtBAgregarProducto_Categoria.BackColor = Color.White;
            txtBAgregarProducto_Categoria.Location = new Point(271, 329);
            txtBAgregarProducto_Categoria.Name = "txtBAgregarProducto_Categoria";
            txtBAgregarProducto_Categoria.Size = new Size(297, 27);
            txtBAgregarProducto_Categoria.TabIndex = 7;
            txtBAgregarProducto_Categoria.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(604, 168);
            button1.Name = "button1";
            button1.Size = new Size(184, 96);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBAgregarProducto_Precio
            // 
            txtBAgregarProducto_Precio.BackColor = Color.White;
            txtBAgregarProducto_Precio.Location = new Point(271, 115);
            txtBAgregarProducto_Precio.Name = "txtBAgregarProducto_Precio";
            txtBAgregarProducto_Precio.Size = new Size(297, 27);
            txtBAgregarProducto_Precio.TabIndex = 5;
            txtBAgregarProducto_Precio.UseWaitCursor = true;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBAgregarProducto_Categoria);
            Controls.Add(txtBAgregarProducto_Codigo);
            Controls.Add(txtBAgregarProducto_Precio);
            Controls.Add(txtBAgregarProducto_Nombre);
            Controls.Add(lblAgregarProducto_Categoria);
            Controls.Add(lblAgregarProducto_Codigo);
            Controls.Add(lblAgregarProducto_Precio);
            Controls.Add(lblAgregarProducto_Nombre);
            Name = "FrmAgregarProducto";
            Text = "FrmAgregarProducto";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgregarProducto_Nombre;
        private Label lblAgregarProducto_Precio;
        private Label lblAgregarProducto_Codigo;
        private Label lblAgregarProducto_Categoria;
        private TextBox txtBAgregarProducto_Nombre;
        private TextBox txtBAgregarProducto_Codigo;
        private TextBox txtBAgregarProducto_Categoria;
        private Button button1;
        private TextBox txtBAgregarProducto_Precio;
    }
}