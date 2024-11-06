namespace POOClase_WinForms;

partial class FrmLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pctbLogin = new PictureBox();
        lblLogin_Usuario = new Label();
        lblLogin_Contraseña = new Label();
        txtBLogin_Usuario = new TextBox();
        txtBLogin_Contraseña = new TextBox();
        btnLogin = new Button();
        lblLogin_Titulo = new Label();
        btnLogin_Salir = new Button();
        ((System.ComponentModel.ISupportInitialize)pctbLogin).BeginInit();
        SuspendLayout();
        // 
        // pctbLogin
        // 
        pctbLogin.BackColor = Color.AntiqueWhite;
        pctbLogin.BackgroundImageLayout = ImageLayout.None;
        pctbLogin.Image = Properties.Resources.wtf_what_the_fuck;
        pctbLogin.Location = new Point(649, 57);
        pctbLogin.Name = "pctbLogin";
        pctbLogin.Size = new Size(569, 527);
        pctbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
        pctbLogin.TabIndex = 0;
        pctbLogin.TabStop = false;
        // 
        // lblLogin_Usuario
        // 
        lblLogin_Usuario.AutoSize = true;
        lblLogin_Usuario.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblLogin_Usuario.Location = new Point(12, 168);
        lblLogin_Usuario.Name = "lblLogin_Usuario";
        lblLogin_Usuario.RightToLeft = RightToLeft.No;
        lblLogin_Usuario.Size = new Size(240, 39);
        lblLogin_Usuario.TabIndex = 1;
        lblLogin_Usuario.Text = "Ingrese Usuario";
        // 
        // lblLogin_Contraseña
        // 
        lblLogin_Contraseña.AutoSize = true;
        lblLogin_Contraseña.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblLogin_Contraseña.Location = new Point(12, 302);
        lblLogin_Contraseña.Name = "lblLogin_Contraseña";
        lblLogin_Contraseña.RightToLeft = RightToLeft.No;
        lblLogin_Contraseña.Size = new Size(293, 39);
        lblLogin_Contraseña.TabIndex = 2;
        lblLogin_Contraseña.Text = "Ingrese Contraseña";
        // 
        // txtBLogin_Usuario
        // 
        txtBLogin_Usuario.Location = new Point(12, 210);
        txtBLogin_Usuario.Name = "txtBLogin_Usuario";
        txtBLogin_Usuario.Size = new Size(315, 27);
        txtBLogin_Usuario.TabIndex = 3;
        // 
        // txtBLogin_Contraseña
        // 
        txtBLogin_Contraseña.Location = new Point(12, 344);
        txtBLogin_Contraseña.Name = "txtBLogin_Contraseña";
        txtBLogin_Contraseña.PasswordChar = '●';
        txtBLogin_Contraseña.Size = new Size(315, 27);
        txtBLogin_Contraseña.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = SystemColors.InactiveCaption;
        btnLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogin.Location = new Point(21, 545);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(242, 39);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Iniciar Sesion";
        btnLogin.UseVisualStyleBackColor = false;
        // 
        // lblLogin_Titulo
        // 
        lblLogin_Titulo.AutoSize = true;
        lblLogin_Titulo.Font = new Font("Microsoft JhengHei UI Light", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblLogin_Titulo.Location = new Point(164, 9);
        lblLogin_Titulo.Name = "lblLogin_Titulo";
        lblLogin_Titulo.Size = new Size(244, 47);
        lblLogin_Titulo.TabIndex = 6;
        lblLogin_Titulo.Text = "Práctica POO";
        lblLogin_Titulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnLogin_Salir
        // 
        btnLogin_Salir.BackColor = SystemColors.InactiveCaption;
        btnLogin_Salir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogin_Salir.Location = new Point(331, 545);
        btnLogin_Salir.Name = "btnLogin_Salir";
        btnLogin_Salir.Size = new Size(242, 39);
        btnLogin_Salir.TabIndex = 7;
        btnLogin_Salir.Text = "Salir";
        btnLogin_Salir.UseVisualStyleBackColor = false;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1262, 673);
        Controls.Add(btnLogin_Salir);
        Controls.Add(lblLogin_Titulo);
        Controls.Add(btnLogin);
        Controls.Add(txtBLogin_Contraseña);
        Controls.Add(txtBLogin_Usuario);
        Controls.Add(lblLogin_Contraseña);
        Controls.Add(lblLogin_Usuario);
        Controls.Add(pctbLogin);
        FormBorderStyle = FormBorderStyle.SizableToolWindow;
        Name = "FrmLogin";
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pctbLogin).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pctbLogin;
    public Label lblLogin_Usuario;
    public Label lblLogin_Contraseña;
    public TextBox txtBLogin_Usuario;
    public TextBox txtBLogin_Contraseña;
    public Button btnLogin;
    public Label lblLogin_Titulo;
    public Button btnLogin_Salir;
}
