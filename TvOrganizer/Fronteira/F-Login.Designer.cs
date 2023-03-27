namespace TVOrganizer
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pBIcon = new PictureBox();
            lblTvOrganizer = new Label();
            lblLogin = new Label();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            lblNomeCadastro = new Label();
            lblSenha = new Label();
            btnCadastrar = new Button();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pBIcon).BeginInit();
            SuspendLayout();
            // 
            // pBIcon
            // 
            pBIcon.Image = (Image)resources.GetObject("pBIcon.Image");
            pBIcon.Location = new Point(136, 12);
            pBIcon.Name = "pBIcon";
            pBIcon.Size = new Size(226, 200);
            pBIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBIcon.TabIndex = 0;
            pBIcon.TabStop = false;
            // 
            // lblTvOrganizer
            // 
            lblTvOrganizer.AutoSize = true;
            lblTvOrganizer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTvOrganizer.Location = new Point(171, 215);
            lblTvOrganizer.Name = "lblTvOrganizer";
            lblTvOrganizer.Size = new Size(149, 31);
            lblTvOrganizer.TabIndex = 1;
            lblTvOrganizer.Text = "Tv Organizer";
            lblTvOrganizer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(209, 270);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(63, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(78, 346);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Insira o seu cadastro...";
            txtUser.Size = new Size(336, 27);
            txtUser.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(78, 427);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.PlaceholderText = "Insira sua senha...";
            txtSenha.Size = new Size(336, 27);
            txtSenha.TabIndex = 4;
            // 
            // lblNomeCadastro
            // 
            lblNomeCadastro.AutoSize = true;
            lblNomeCadastro.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeCadastro.Location = new Point(78, 320);
            lblNomeCadastro.Margin = new Padding(0, 0, 3, 0);
            lblNomeCadastro.Name = "lblNomeCadastro";
            lblNomeCadastro.Size = new Size(149, 23);
            lblNomeCadastro.TabIndex = 5;
            lblNomeCadastro.Text = "Nome Cadastrado";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(78, 401);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(78, 491);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 40);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(314, 491);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 40);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(482, 553);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenha);
            Controls.Add(lblNomeCadastro);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(lblLogin);
            Controls.Add(lblTvOrganizer);
            Controls.Add(pBIcon);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pBIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBIcon;
        private Label lblTvOrganizer;
        private Label lblLogin;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Label lblNomeCadastro;
        private Label lblSenha;
        private Button btnCadastrar;
        private Button btnEntrar;
    }
}