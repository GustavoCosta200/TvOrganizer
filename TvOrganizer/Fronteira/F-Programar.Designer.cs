namespace TvOrganizer.Fronteira
{
    partial class frmProgramar
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
            dtpData = new DateTimePicker();
            lblData = new Label();
            label1 = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            mtbHora = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(549, 85);
            lblNome.TabIndex = 0;
            lblNome.Text = "placeholder";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(39, 138);
            dtpData.MinDate = new DateTime(2023, 3, 29, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(311, 27);
            dtpData.TabIndex = 1;
            dtpData.Value = new DateTime(2023, 3, 29, 0, 0, 0, 0);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.Location = new Point(39, 94);
            lblData.Name = "lblData";
            lblData.Size = new Size(63, 31);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 94);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 3;
            label1.Text = "Hora";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(39, 362);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 48);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(432, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 48);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mtbHora
            // 
            mtbHora.Location = new Point(418, 138);
            mtbHora.Mask = "00:00";
            mtbHora.Name = "mtbHora";
            mtbHora.Size = new Size(125, 27);
            mtbHora.TabIndex = 4;
            mtbHora.MaskInputRejected += mtbHora_MaskInputRejected;
            // 
            // frmProgramar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 422);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(mtbHora);
            Controls.Add(label1);
            Controls.Add(lblData);
            Controls.Add(dtpData);
            Controls.Add(lblNome);
            MaximizeBox = false;
            Name = "frmProgramar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Programar";
            Load += frmProgramar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private DateTimePicker dtpData;
        private Label lblData;
        private Label label1;
        private MaskedTextBox mtbHora;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}