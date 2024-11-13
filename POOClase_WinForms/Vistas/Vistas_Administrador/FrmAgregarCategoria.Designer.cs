namespace POOClase_WinForms.Vistas
{
    partial class FrmAgregarCategoria
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
            lblNombreCategoria = new Label();
            lblPrecioMinimo = new Label();
            txtBNombreCategoria = new TextBox();
            txtBPrecioMinimo = new TextBox();
            btnAgregarCategoria_Agregar = new Button();
            btnAgregarCategoria_Salir = new Button();
            SuspendLayout();
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCategoria.Location = new Point(12, 39);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(253, 30);
            lblNombreCategoria.TabIndex = 0;
            lblNombreCategoria.Text = "Nombre de categoría";
            // 
            // lblPrecioMinimo
            // 
            lblPrecioMinimo.AutoSize = true;
            lblPrecioMinimo.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioMinimo.Location = new Point(91, 93);
            lblPrecioMinimo.Name = "lblPrecioMinimo";
            lblPrecioMinimo.Size = new Size(174, 30);
            lblPrecioMinimo.TabIndex = 1;
            lblPrecioMinimo.Text = "Precio Minimo";
            // 
            // txtBNombreCategoria
            // 
            txtBNombreCategoria.Location = new Point(271, 44);
            txtBNombreCategoria.Name = "txtBNombreCategoria";
            txtBNombreCategoria.Size = new Size(265, 27);
            txtBNombreCategoria.TabIndex = 2;
            // 
            // txtBPrecioMinimo
            // 
            txtBPrecioMinimo.Location = new Point(271, 98);
            txtBPrecioMinimo.Name = "txtBPrecioMinimo";
            txtBPrecioMinimo.Size = new Size(265, 27);
            txtBPrecioMinimo.TabIndex = 3;
            // 
            // btnAgregarCategoria_Agregar
            // 
            btnAgregarCategoria_Agregar.BackColor = SystemColors.ActiveCaption;
            btnAgregarCategoria_Agregar.Location = new Point(565, 44);
            btnAgregarCategoria_Agregar.Name = "btnAgregarCategoria_Agregar";
            btnAgregarCategoria_Agregar.Size = new Size(214, 81);
            btnAgregarCategoria_Agregar.TabIndex = 4;
            btnAgregarCategoria_Agregar.Text = "AGREGAR";
            btnAgregarCategoria_Agregar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCategoria_Salir
            // 
            btnAgregarCategoria_Salir.BackColor = Color.IndianRed;
            btnAgregarCategoria_Salir.Location = new Point(565, 344);
            btnAgregarCategoria_Salir.Name = "btnAgregarCategoria_Salir";
            btnAgregarCategoria_Salir.Size = new Size(214, 81);
            btnAgregarCategoria_Salir.TabIndex = 5;
            btnAgregarCategoria_Salir.Text = "SALIR";
            btnAgregarCategoria_Salir.UseVisualStyleBackColor = false;
            // 
            // FrmAgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarCategoria_Salir);
            Controls.Add(btnAgregarCategoria_Agregar);
            Controls.Add(txtBPrecioMinimo);
            Controls.Add(txtBNombreCategoria);
            Controls.Add(lblPrecioMinimo);
            Controls.Add(lblNombreCategoria);
            Name = "FrmAgregarCategoria";
            Text = "FrmAgregarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCategoria;
        private Label lblPrecioMinimo;
        public Button btnAgregarCategoria_Agregar;
        public TextBox txtBNombreCategoria;
        public TextBox txtBPrecioMinimo;
        public Button btnAgregarCategoria_Salir;
    }
}