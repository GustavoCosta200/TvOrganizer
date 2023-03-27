namespace TVOrganizer.Fronteira
{
    partial class frmCadastro
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
            lblCadastro = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblConfirmSenha = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtBoxSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCadastro.Location = new Point(200, 32);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(139, 41);
            lblCadastro.TabIndex = 0;
            lblCadastro.Text = "Cadastro";
            lblCadastro.TextAlign = ContentAlignment.MiddleCenter;
            lblCadastro.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(50, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(50, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(50, 285);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmSenha
            // 
            lblConfirmSenha.AutoSize = true;
            lblConfirmSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmSenha.Location = new Point(50, 375);
            lblConfirmSenha.Name = "lblConfirmSenha";
            lblConfirmSenha.Size = new Size(139, 23);
            lblConfirmSenha.TabIndex = 4;
            lblConfirmSenha.Text = "Confirmar Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Insira seu Email...";
            txtEmail.Size = new Size(221, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 140);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Insira seu Username...";
            txtNome.Size = new Size(219, 27);
            txtNome.TabIndex = 6;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(48, 320);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PasswordChar = '•';
            txtBoxSenha.PlaceholderText = "Insira sua Senha...";
            txtBoxSenha.Size = new Size(221, 27);
            txtBoxSenha.TabIndex = 7;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(48, 410);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '•';
            txtConfirmarSenha.PlaceholderText = "Confirme sua Senha...";
            txtConfirmarSenha.Size = new Size(221, 27);
            txtConfirmarSenha.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(275, 490);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(155, 45);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(48, 490);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 45);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirmSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblCadastro);
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro";
            Load += frmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastro;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblConfirmSenha;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtBoxSenha;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}