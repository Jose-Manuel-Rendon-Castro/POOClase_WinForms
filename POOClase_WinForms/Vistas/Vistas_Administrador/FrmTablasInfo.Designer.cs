namespace POOClase_WinForms.Vistas.Vistas_Administrador
{
    partial class FrmTablasInfo
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
            label1 = new Label();
            combxTablasInfo_NombreTabla = new ComboBox();
            dtgvTablasInfo_Tabla = new DataGridView();
            btnTablaInfo_Salir = new Button();
            btnTablasInfo_Mostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvTablasInfo_Tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 27);
            label1.TabIndex = 0;
            label1.Text = "Tabla:";
            // 
            // combxTablasInfo_NombreTabla
            // 
            combxTablasInfo_NombreTabla.DropDownStyle = ComboBoxStyle.DropDownList;
            combxTablasInfo_NombreTabla.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combxTablasInfo_NombreTabla.FormattingEnabled = true;
            combxTablasInfo_NombreTabla.Items.AddRange(new object[] { "categoria", "producto" });
            combxTablasInfo_NombreTabla.Location = new Point(12, 39);
            combxTablasInfo_NombreTabla.Name = "combxTablasInfo_NombreTabla";
            combxTablasInfo_NombreTabla.Size = new Size(167, 35);
            combxTablasInfo_NombreTabla.TabIndex = 1;
            // 
            // dtgvTablasInfo_Tabla
            // 
            dtgvTablasInfo_Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTablasInfo_Tabla.Location = new Point(12, 118);
            dtgvTablasInfo_Tabla.Name = "dtgvTablasInfo_Tabla";
            dtgvTablasInfo_Tabla.RowHeadersWidth = 51;
            dtgvTablasInfo_Tabla.Size = new Size(1063, 423);
            dtgvTablasInfo_Tabla.TabIndex = 2;
            // 
            // btnTablaInfo_Salir
            // 
            btnTablaInfo_Salir.BackColor = Color.IndianRed;
            btnTablaInfo_Salir.Font = new Font("Microsoft YaHei UI", 12F);
            btnTablaInfo_Salir.Location = new Point(872, 32);
            btnTablaInfo_Salir.Name = "btnTablaInfo_Salir";
            btnTablaInfo_Salir.Size = new Size(203, 46);
            btnTablaInfo_Salir.TabIndex = 3;
            btnTablaInfo_Salir.Text = "SALIR";
            btnTablaInfo_Salir.UseVisualStyleBackColor = false;
            // 
            // btnTablasInfo_Mostrar
            // 
            btnTablasInfo_Mostrar.BackColor = SystemColors.ActiveCaption;
            btnTablasInfo_Mostrar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablasInfo_Mostrar.Location = new Point(219, 35);
            btnTablasInfo_Mostrar.Name = "btnTablasInfo_Mostrar";
            btnTablasInfo_Mostrar.Size = new Size(254, 40);
            btnTablasInfo_Mostrar.TabIndex = 4;
            btnTablasInfo_Mostrar.Text = "Mostrar Tabla";
            btnTablasInfo_Mostrar.UseVisualStyleBackColor = false;
            // 
            // FrmTablasInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 553);
            Controls.Add(btnTablasInfo_Mostrar);
            Controls.Add(btnTablaInfo_Salir);
            Controls.Add(dtgvTablasInfo_Tabla);
            Controls.Add(combxTablasInfo_NombreTabla);
            Controls.Add(label1);
            Name = "FrmTablasInfo";
            Text = "FrmTablasInfo";
            ((System.ComponentModel.ISupportInitialize)dtgvTablasInfo_Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ComboBox combxTablasInfo_NombreTabla;
        public Button btnTablaInfo_Salir;
        public DataGridView dtgvTablasInfo_Tabla;
        public Button btnTablasInfo_Mostrar;
    }
}