namespace TvOrganizer.Fronteira
{
    partial class frmAvaliar
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
            lblNome = new Label();
            txtComentário = new TextBox();
            lblComentário = new Label();
            nudNota = new NumericUpDown();
            label1 = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoEllipsis = true;
            lblNome.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(23, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(514, 46);
            lblNome.TabIndex = 0;
            lblNome.Text = "placeholder";
            lblNome.TextAlign = ContentAlignment.TopCenter;
            lblNome.Click += label1_Click;
            // 
            // txtComentário
            // 
            txtComentário.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtComentário.Location = new Point(23, 122);
            txtComentário.Multiline = true;
            txtComentário.Name = "txtComentário";
            txtComentário.Size = new Size(384, 201);
            txtComentário.TabIndex = 1;
            // 
            // lblComentário
            // 
            lblComentário.AutoSize = true;
            lblComentário.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentário.Location = new Point(23, 96);
            lblComentário.Name = "lblComentário";
            lblComentário.Size = new Size(100, 23);
            lblComentário.TabIndex = 2;
            lblComentário.Text = "Comentário";
            // 
            // nudNota
            // 
            nudNota.DecimalPlaces = 1;
            nudNota.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudNota.Location = new Point(445, 122);
            nudNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(78, 27);
            nudNota.TabIndex = 3;
            nudNota.ValueChanged += nudNota_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(459, 99);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 4;
            label1.Text = "Nota";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(427, 193);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 57);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar Avaliação";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(427, 269);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(110, 54);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmAvaliar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 357);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(nudNota);
            Controls.Add(lblComentário);
            Controls.Add(txtComentário);
            Controls.Add(lblNome);
            MaximizeBox = false;
            Name = "frmAvaliar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Avaliar";
            Load += F_Avaliar_Load;
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtComentário;
        private Label lblComentário;
        private NumericUpDown nudNota;
        private Label label1;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}