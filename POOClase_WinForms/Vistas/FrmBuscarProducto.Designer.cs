namespace POOClase_WinForms
{
    partial class FrmBuscarProducto
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
            lblBuscar1 = new Label();
            txtBBuscar = new TextBox();
            label1 = new Label();
            btnBuscar_Salir = new Button();
            SuspendLayout();
            // 
            // lblBuscar1
            // 
            lblBuscar1.AutoSize = true;
            lblBuscar1.Font = new Font("Microsoft YaHei UI Light", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscar1.Location = new Point(12, 9);
            lblBuscar1.Name = "lblBuscar1";
            lblBuscar1.Size = new Size(488, 39);
            lblBuscar1.TabIndex = 0;
            lblBuscar1.Text = "Ingrese una ID para buscar su info ";
            // 
            // txtBBuscar
            // 
            txtBBuscar.Location = new Point(12, 51);
            txtBBuscar.Name = "txtBBuscar";
            txtBBuscar.Size = new Size(478, 27);
            txtBBuscar.TabIndex = 1;
            txtBBuscar.PreviewKeyDown += txtBBuscar_PreviewKeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 2;
            label1.PreviewKeyDown += label1_PreviewKeyDown;
            // 
            // btnBuscar_Salir
            // 
            btnBuscar_Salir.BackColor = SystemColors.ActiveCaption;
            btnBuscar_Salir.Location = new Point(598, 49);
            btnBuscar_Salir.Name = "btnBuscar_Salir";
            btnBuscar_Salir.Size = new Size(94, 29);
            btnBuscar_Salir.TabIndex = 3;
            btnBuscar_Salir.Text = "Salir";
            btnBuscar_Salir.UseVisualStyleBackColor = false;
            btnBuscar_Salir.Click += btnBuscar_Salir_Click;
            // 
            // FrmBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar_Salir);
            Controls.Add(label1);
            Controls.Add(txtBBuscar);
            Controls.Add(lblBuscar1);
            Name = "FrmBuscarProducto";
            Text = "FrmBuscarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar1;
        private TextBox txtBBuscar;
        private Label label1;
        private Button btnBuscar_Salir;
    }
}