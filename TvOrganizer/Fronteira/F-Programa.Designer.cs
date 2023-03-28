namespace TVOrganizer.Fronteira
{
    partial class frmPrograma
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
            ptbPoster = new PictureBox();
            lblTítulo = new Label();
            label1 = new Label();
            lblSinopse = new Label();
            label2 = new Label();
            gbInfo = new GroupBox();
            lblStatus = new Label();
            lblNumTemp = new Label();
            lblNumEp = new Label();
            lblDuração = new Label();
            lblNota = new Label();
            lblDataLançamento = new Label();
            ltbGêneros = new ListBox();
            lblGêneros = new Label();
            btnVoltar = new Button();
            btnEpisódios = new Button();
            btnConcluido = new Button();
            btnAssistir = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbPoster).BeginInit();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ptbPoster
            // 
            ptbPoster.Location = new Point(179, 12);
            ptbPoster.Name = "ptbPoster";
            ptbPoster.Size = new Size(324, 249);
            ptbPoster.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbPoster.TabIndex = 0;
            ptbPoster.TabStop = false;
            // 
            // lblTítulo
            // 
            lblTítulo.AutoEllipsis = true;
            lblTítulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTítulo.Location = new Point(9, 264);
            lblTítulo.Name = "lblTítulo";
            lblTítulo.Size = new Size(669, 48);
            lblTítulo.TabIndex = 1;
            lblTítulo.Text = "placeholder";
            lblTítulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTítulo.Click += label1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(0, 303);
            label1.Name = "label1";
            label1.Size = new Size(678, 1);
            label1.TabIndex = 2;
            // 
            // lblSinopse
            // 
            lblSinopse.AutoEllipsis = true;
            lblSinopse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinopse.Location = new Point(18, 325);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(650, 56);
            lblSinopse.TabIndex = 3;
            lblSinopse.Text = "label2";
            lblSinopse.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(0, 403);
            label2.Name = "label2";
            label2.Size = new Size(678, 1);
            label2.TabIndex = 4;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblStatus);
            gbInfo.Controls.Add(lblNumTemp);
            gbInfo.Controls.Add(lblNumEp);
            gbInfo.Controls.Add(lblDuração);
            gbInfo.Controls.Add(lblNota);
            gbInfo.Controls.Add(lblDataLançamento);
            gbInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbInfo.Location = new Point(18, 407);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(521, 194);
            gbInfo.TabIndex = 5;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informações";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(293, 148);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 23);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status: ";
            // 
            // lblNumTemp
            // 
            lblNumTemp.AutoSize = true;
            lblNumTemp.Location = new Point(293, 97);
            lblNumTemp.Name = "lblNumTemp";
            lblNumTemp.Size = new Size(111, 23);
            lblNumTemp.TabIndex = 4;
            lblNumTemp.Text = "Temporadas: ";
            lblNumTemp.Click += label3_Click;
            // 
            // lblNumEp
            // 
            lblNumEp.AutoSize = true;
            lblNumEp.Location = new Point(293, 50);
            lblNumEp.Name = "lblNumEp";
            lblNumEp.Size = new Size(182, 23);
            lblNumEp.TabIndex = 3;
            lblNumEp.Text = "Número de Episódios: ";
            // 
            // lblDuração
            // 
            lblDuração.AutoSize = true;
            lblDuração.Location = new Point(6, 148);
            lblDuração.Name = "lblDuração";
            lblDuração.Size = new Size(78, 23);
            lblDuração.TabIndex = 2;
            lblDuração.Text = "Duração:";
            lblDuração.Click += lblDuração_Click;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(6, 97);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(57, 23);
            lblNota.TabIndex = 1;
            lblNota.Text = "Nota: ";
            // 
            // lblDataLançamento
            // 
            lblDataLançamento.AutoEllipsis = true;
            lblDataLançamento.AutoSize = true;
            lblDataLançamento.Location = new Point(6, 50);
            lblDataLançamento.Name = "lblDataLançamento";
            lblDataLançamento.Size = new Size(112, 23);
            lblDataLançamento.TabIndex = 0;
            lblDataLançamento.Text = "Lançado em: ";
            // 
            // ltbGêneros
            // 
            ltbGêneros.FormattingEnabled = true;
            ltbGêneros.ItemHeight = 20;
            ltbGêneros.Location = new Point(545, 457);
            ltbGêneros.Name = "ltbGêneros";
            ltbGêneros.Size = new Size(123, 144);
            ltbGêneros.TabIndex = 7;
            // 
            // lblGêneros
            // 
            lblGêneros.AutoSize = true;
            lblGêneros.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGêneros.Location = new Point(545, 422);
            lblGêneros.Name = "lblGêneros";
            lblGêneros.Size = new Size(73, 23);
            lblGêneros.TabIndex = 8;
            lblGêneros.Text = "Gêneros";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(18, 637);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(118, 35);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEpisódios
            // 
            btnEpisódios.Location = new Point(179, 637);
            btnEpisódios.Name = "btnEpisódios";
            btnEpisódios.Size = new Size(118, 35);
            btnEpisódios.TabIndex = 10;
            btnEpisódios.Text = "Ver Episódios";
            btnEpisódios.UseVisualStyleBackColor = true;
            // 
            // btnConcluido
            // 
            btnConcluido.Location = new Point(334, 637);
            btnConcluido.Name = "btnConcluido";
            btnConcluido.Size = new Size(145, 35);
            btnConcluido.TabIndex = 11;
            btnConcluido.Text = "Marcar Concluído";
            btnConcluido.UseVisualStyleBackColor = true;
            // 
            // btnAssistir
            // 
            btnAssistir.Location = new Point(523, 637);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(145, 35);
            btnAssistir.TabIndex = 12;
            btnAssistir.Text = "Marcar Assistir";
            btnAssistir.UseVisualStyleBackColor = true;
            // 
            // frmPrograma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 684);
            Controls.Add(btnAssistir);
            Controls.Add(btnConcluido);
            Controls.Add(btnEpisódios);
            Controls.Add(btnVoltar);
            Controls.Add(lblGêneros);
            Controls.Add(ltbGêneros);
            Controls.Add(gbInfo);
            Controls.Add(label2);
            Controls.Add(lblSinopse);
            Controls.Add(label1);
            Controls.Add(lblTítulo);
            Controls.Add(ptbPoster);
            MaximizeBox = false;
            Name = "frmPrograma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "F_Programa";
            Load += frmPrograma_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPoster).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbPoster;
        private Label lblTítulo;
        private Label label1;
        private Label lblSinopse;
        private Label label2;
        private GroupBox gbInfo;
        private Label lblDuração;
        private Label lblNota;
        private Label lblDataLançamento;
        private Label lblNumEp;
        private Label lblNumTemp;
        private Label lblStatus;
        private ListBox ltbGêneros;
        private Label lblGêneros;
        private Button btnVoltar;
        private Button btnEpisódios;
        private Button btnConcluido;
        private Button btnAssistir;
    }
}