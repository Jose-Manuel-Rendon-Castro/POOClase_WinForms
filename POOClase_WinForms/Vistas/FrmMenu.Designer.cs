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
            button1 = new Button();
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
            btnAgregarProducto.Click += btnAgregarProducto_Click;
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
            btnMenu_Buscar.Click += btnMenu_Buscar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(590, 17);
            button1.Name = "button1";
            button1.Size = new Size(198, 39);
            button1.TabIndex = 3;
            button1.Text = "Cerrar sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnMenu_Buscar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblMenu_Bienvenido);
            Name = "FrmMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu_Bienvenido;
        private Button btnAgregarProducto;
        private Button btnMenu_Buscar;
        private Button button1;
    }
}