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
            txtBTablasInfo_ID = new TextBox();
            lblTablasInfo_ID = new Label();
            label2 = new Label();
            txtBTablasInfo_NombreElemento = new TextBox();
            label3 = new Label();
            txtBTablasInfo_NombreCategoria = new TextBox();
            label4 = new Label();
            numupTablasInfo_De = new NumericUpDown();
            lblTablaInfo_PrecioDe = new Label();
            label5 = new Label();
            numupTablasInfo_Hasta = new NumericUpDown();
            btnTablasInfo_Limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvTablasInfo_Tabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupTablasInfo_De).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupTablasInfo_Hasta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 97);
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
            combxTablasInfo_NombreTabla.Location = new Point(11, 127);
            combxTablasInfo_NombreTabla.Name = "combxTablasInfo_NombreTabla";
            combxTablasInfo_NombreTabla.Size = new Size(213, 35);
            combxTablasInfo_NombreTabla.TabIndex = 1;
            // 
            // dtgvTablasInfo_Tabla
            // 
            dtgvTablasInfo_Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTablasInfo_Tabla.Location = new Point(11, 295);
            dtgvTablasInfo_Tabla.Name = "dtgvTablasInfo_Tabla";
            dtgvTablasInfo_Tabla.RowHeadersWidth = 51;
            dtgvTablasInfo_Tabla.Size = new Size(1448, 463);
            dtgvTablasInfo_Tabla.TabIndex = 2;
            // 
            // btnTablaInfo_Salir
            // 
            btnTablaInfo_Salir.BackColor = Color.IndianRed;
            btnTablaInfo_Salir.Font = new Font("Microsoft YaHei UI", 12F);
            btnTablaInfo_Salir.Location = new Point(1256, 86);
            btnTablaInfo_Salir.Name = "btnTablaInfo_Salir";
            btnTablaInfo_Salir.Size = new Size(203, 102);
            btnTablaInfo_Salir.TabIndex = 3;
            btnTablaInfo_Salir.Text = "SALIR";
            btnTablaInfo_Salir.UseVisualStyleBackColor = false;
            // 
            // btnTablasInfo_Mostrar
            // 
            btnTablasInfo_Mostrar.BackColor = SystemColors.ActiveCaption;
            btnTablasInfo_Mostrar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablasInfo_Mostrar.Location = new Point(970, 12);
            btnTablasInfo_Mostrar.Name = "btnTablasInfo_Mostrar";
            btnTablasInfo_Mostrar.Size = new Size(254, 121);
            btnTablasInfo_Mostrar.TabIndex = 4;
            btnTablasInfo_Mostrar.Text = "Mostrar Tabla";
            btnTablasInfo_Mostrar.UseVisualStyleBackColor = false;
            // 
            // txtBTablasInfo_ID
            // 
            txtBTablasInfo_ID.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBTablasInfo_ID.Location = new Point(305, 56);
            txtBTablasInfo_ID.Name = "txtBTablasInfo_ID";
            txtBTablasInfo_ID.Size = new Size(175, 33);
            txtBTablasInfo_ID.TabIndex = 5;
            // 
            // lblTablasInfo_ID
            // 
            lblTablasInfo_ID.AutoSize = true;
            lblTablasInfo_ID.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTablasInfo_ID.Location = new Point(305, 28);
            lblTablasInfo_ID.Name = "lblTablasInfo_ID";
            lblTablasInfo_ID.Size = new Size(32, 25);
            lblTablasInfo_ID.TabIndex = 6;
            lblTablasInfo_ID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 184);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txtBTablasInfo_NombreElemento
            // 
            txtBTablasInfo_NombreElemento.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBTablasInfo_NombreElemento.Location = new Point(305, 212);
            txtBTablasInfo_NombreElemento.Name = "txtBTablasInfo_NombreElemento";
            txtBTablasInfo_NombreElemento.Size = new Size(175, 33);
            txtBTablasInfo_NombreElemento.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(596, 28);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre-Categoria";
            // 
            // txtBTablasInfo_NombreCategoria
            // 
            txtBTablasInfo_NombreCategoria.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBTablasInfo_NombreCategoria.Location = new Point(596, 56);
            txtBTablasInfo_NombreCategoria.Name = "txtBTablasInfo_NombreCategoria";
            txtBTablasInfo_NombreCategoria.Size = new Size(175, 33);
            txtBTablasInfo_NombreCategoria.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(596, 184);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 12;
            label4.Text = "Precio";
            // 
            // numupTablasInfo_De
            // 
            numupTablasInfo_De.Location = new Point(637, 218);
            numupTablasInfo_De.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numupTablasInfo_De.Name = "numupTablasInfo_De";
            numupTablasInfo_De.Size = new Size(84, 27);
            numupTablasInfo_De.TabIndex = 13;
            // 
            // lblTablaInfo_PrecioDe
            // 
            lblTablaInfo_PrecioDe.AutoSize = true;
            lblTablaInfo_PrecioDe.Location = new Point(600, 220);
            lblTablaInfo_PrecioDe.Name = "lblTablaInfo_PrecioDe";
            lblTablaInfo_PrecioDe.Size = new Size(31, 20);
            lblTablaInfo_PrecioDe.TabIndex = 14;
            lblTablaInfo_PrecioDe.Text = "De:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(738, 220);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 16;
            label5.Text = "Hasta:";
            // 
            // numupTablasInfo_Hasta
            // 
            numupTablasInfo_Hasta.Location = new Point(794, 218);
            numupTablasInfo_Hasta.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numupTablasInfo_Hasta.Name = "numupTablasInfo_Hasta";
            numupTablasInfo_Hasta.Size = new Size(84, 27);
            numupTablasInfo_Hasta.TabIndex = 15;
            numupTablasInfo_Hasta.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // btnTablasInfo_Limpiar
            // 
            btnTablasInfo_Limpiar.BackColor = SystemColors.ActiveCaption;
            btnTablasInfo_Limpiar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablasInfo_Limpiar.Location = new Point(970, 168);
            btnTablasInfo_Limpiar.Name = "btnTablasInfo_Limpiar";
            btnTablasInfo_Limpiar.Size = new Size(254, 121);
            btnTablasInfo_Limpiar.TabIndex = 17;
            btnTablasInfo_Limpiar.Text = "Limpiar campos";
            btnTablasInfo_Limpiar.UseVisualStyleBackColor = false;
            // 
            // FrmTablasInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 770);
            Controls.Add(btnTablasInfo_Limpiar);
            Controls.Add(label5);
            Controls.Add(numupTablasInfo_Hasta);
            Controls.Add(lblTablaInfo_PrecioDe);
            Controls.Add(numupTablasInfo_De);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBTablasInfo_NombreCategoria);
            Controls.Add(label2);
            Controls.Add(txtBTablasInfo_NombreElemento);
            Controls.Add(lblTablasInfo_ID);
            Controls.Add(txtBTablasInfo_ID);
            Controls.Add(btnTablasInfo_Mostrar);
            Controls.Add(btnTablaInfo_Salir);
            Controls.Add(dtgvTablasInfo_Tabla);
            Controls.Add(combxTablasInfo_NombreTabla);
            Controls.Add(label1);
            Name = "FrmTablasInfo";
            Text = "FrmTablasInfo";
            ((System.ComponentModel.ISupportInitialize)dtgvTablasInfo_Tabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupTablasInfo_De).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupTablasInfo_Hasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ComboBox combxTablasInfo_NombreTabla;
        public Button btnTablaInfo_Salir;
        public DataGridView dtgvTablasInfo_Tabla;
        public Button btnTablasInfo_Mostrar;
        public TextBox txtBTablasInfo_ID;
        public Label lblTablasInfo_ID;
        public Label label2;
        public Label label3;
        public TextBox txtBTablasInfo_NombreCategoria;
        public Label label4;
        public TextBox txtBTablasInfo_NombreElemento;
        private Label lblTablaInfo_PrecioDe;
        private Label label5;
        public NumericUpDown numupTablasInfo_De;
        public NumericUpDown numupTablasInfo_Hasta;
        private NumericUpDown numericUpDown2;
        public Button btnTablasInfo_Limpiar;
    }
}