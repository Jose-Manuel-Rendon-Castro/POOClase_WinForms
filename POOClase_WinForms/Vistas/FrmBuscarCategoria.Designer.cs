namespace POOClase_WinForms.Vistas
{
    partial class FrmBuscarCategoria
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
            btnBuscarCategoria_Salir = new Button();
            lblBuscarCategoria_ShowInfo = new Label();
            txtBBuscarCategoria = new TextBox();
            lblBuscar = new Label();
            SuspendLayout();
            // 
            // btnBuscarCategoria_Salir
            // 
            btnBuscarCategoria_Salir.BackColor = SystemColors.ActiveCaption;
            btnBuscarCategoria_Salir.Location = new Point(603, 97);
            btnBuscarCategoria_Salir.Name = "btnBuscarCategoria_Salir";
            btnBuscarCategoria_Salir.Size = new Size(94, 29);
            btnBuscarCategoria_Salir.TabIndex = 7;
            btnBuscarCategoria_Salir.Text = "Salir";
            btnBuscarCategoria_Salir.UseVisualStyleBackColor = false;
            // 
            // lblBuscarCategoria_ShowInfo
            // 
            lblBuscarCategoria_ShowInfo.AutoSize = true;
            lblBuscarCategoria_ShowInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarCategoria_ShowInfo.Location = new Point(12, 138);
            lblBuscarCategoria_ShowInfo.Name = "lblBuscarCategoria_ShowInfo";
            lblBuscarCategoria_ShowInfo.Size = new Size(0, 28);
            lblBuscarCategoria_ShowInfo.TabIndex = 6;
            // 
            // txtBBuscarCategoria
            // 
            txtBBuscarCategoria.Location = new Point(12, 97);
            txtBBuscarCategoria.Name = "txtBBuscarCategoria";
            txtBBuscarCategoria.Size = new Size(478, 27);
            txtBBuscarCategoria.TabIndex = 5;
            // 
            // lblBuscar
            // 
            lblBuscar.Font = new Font("Microsoft YaHei UI Light", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(12, 7);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(488, 87);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Ingrese la ID de la categoria para ver su informacion";
            lblBuscar.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmBuscarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarCategoria_Salir);
            Controls.Add(lblBuscarCategoria_ShowInfo);
            Controls.Add(txtBBuscarCategoria);
            Controls.Add(lblBuscar);
            Name = "FrmBuscarCategoria";
            Text = "FrmBuscarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnBuscarCategoria_Salir;
        public Label lblBuscarCategoria_ShowInfo;
        public TextBox txtBBuscarCategoria;
        public Label lblBuscar;
    }
}