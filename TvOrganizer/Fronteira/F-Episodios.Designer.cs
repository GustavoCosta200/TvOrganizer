namespace TVOrganizer.Fronteira
{
    partial class frmEpisódios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEpisódios = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            Episódio = new DataGridViewTextBoxColumn();
            Temporada = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            lblNome = new Label();
            button1 = new Button();
            btnConcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEpisódios).BeginInit();
            SuspendLayout();
            // 
            // dgvEpisódios
            // 
            dgvEpisódios.AllowUserToAddRows = false;
            dgvEpisódios.AllowUserToDeleteRows = false;
            dgvEpisódios.AllowUserToResizeColumns = false;
            dgvEpisódios.AllowUserToResizeRows = false;
            dgvEpisódios.BackgroundColor = SystemColors.ActiveCaption;
            dgvEpisódios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisódios.Columns.AddRange(new DataGridViewColumn[] { Título, Sinopse, Episódio, Temporada, Id });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvEpisódios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvEpisódios.Location = new Point(0, 129);
            dgvEpisódios.MultiSelect = false;
            dgvEpisódios.Name = "dgvEpisódios";
            dgvEpisódios.ReadOnly = true;
            dgvEpisódios.RowHeadersVisible = false;
            dgvEpisódios.RowHeadersWidth = 51;
            dgvEpisódios.RowTemplate.Height = 29;
            dgvEpisódios.ScrollBars = ScrollBars.Vertical;
            dgvEpisódios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEpisódios.Size = new Size(1071, 465);
            dgvEpisódios.TabIndex = 0;
            dgvEpisódios.CellContentClick += dgvEpisódios_CellContentClick;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.FillWeight = 200F;
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.ReadOnly = true;
            // 
            // Sinopse
            // 
            Sinopse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sinopse.FillWeight = 400F;
            Sinopse.HeaderText = "Sinopse";
            Sinopse.MinimumWidth = 6;
            Sinopse.Name = "Sinopse";
            Sinopse.ReadOnly = true;
            // 
            // Episódio
            // 
            Episódio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Episódio.FillWeight = 80F;
            Episódio.HeaderText = "Episódio";
            Episódio.MinimumWidth = 6;
            Episódio.Name = "Episódio";
            Episódio.ReadOnly = true;
            // 
            // Temporada
            // 
            Temporada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Temporada.FillWeight = 80F;
            Temporada.HeaderText = "Temporada";
            Temporada.MinimumWidth = 6;
            Temporada.Name = "Temporada";
            Temporada.ReadOnly = true;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(425, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(297, 71);
            lblNome.TabIndex = 1;
            lblNome.Text = "placeholder";
            lblNome.Click += lblNome_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 608);
            button1.Name = "button1";
            button1.Size = new Size(99, 50);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.Location = new Point(920, 608);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(140, 50);
            btnConcluir.TabIndex = 3;
            btnConcluir.Text = "Concluir Episódio";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // frmEpisódios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 670);
            Controls.Add(btnConcluir);
            Controls.Add(button1);
            Controls.Add(lblNome);
            Controls.Add(dgvEpisódios);
            MaximizeBox = false;
            Name = "frmEpisódios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Episódios";
            Load += F_Episodios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEpisódios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEpisódios;
        private Label lblNome;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn Episódio;
        private DataGridViewTextBoxColumn Temporada;
        private DataGridViewTextBoxColumn Id;
        private Button button1;
        private Button btnConcluir;
    }
}