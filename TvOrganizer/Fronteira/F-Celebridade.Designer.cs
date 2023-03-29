namespace TVOrganizer.Fronteira
{
    partial class frmCelebridade
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            nudPágina = new NumericUpDown();
            cbbTipos = new ComboBox();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            dgvCelebridadesSearch = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            DataLançamento = new DataGridViewTextBoxColumn();
            Duração = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudPágina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCelebridadesSearch).BeginInit();
            SuspendLayout();
            // 
            // nudPágina
            // 
            nudPágina.Location = new Point(920, 58);
            nudPágina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPágina.Name = "nudPágina";
            nudPágina.Size = new Size(158, 27);
            nudPágina.TabIndex = 9;
            nudPágina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbbTipos
            // 
            cbbTipos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbTipos.FormattingEnabled = true;
            cbbTipos.Items.AddRange(new object[] { "Filme", "Série", "Pessoa" });
            cbbTipos.Location = new Point(419, 58);
            cbbTipos.Name = "cbbTipos";
            cbbTipos.Size = new Size(155, 31);
            cbbTipos.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.Location = new Point(580, 58);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.RightToLeft = RightToLeft.No;
            btnPesquisar.Size = new Size(45, 31);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(-5, 58);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar...";
            txtPesquisa.Size = new Size(406, 30);
            txtPesquisa.TabIndex = 5;
            // 
            // dgvCelebridadesSearch
            // 
            dgvCelebridadesSearch.AllowUserToAddRows = false;
            dgvCelebridadesSearch.AllowUserToDeleteRows = false;
            dgvCelebridadesSearch.AllowUserToOrderColumns = true;
            dgvCelebridadesSearch.AllowUserToResizeColumns = false;
            dgvCelebridadesSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dgvCelebridadesSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCelebridadesSearch.BackgroundColor = SystemColors.ActiveCaption;
            dgvCelebridadesSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCelebridadesSearch.Columns.AddRange(new DataGridViewColumn[] { Título, Sinopse, DataLançamento, Duração });
            dgvCelebridadesSearch.Location = new Point(-3, 143);
            dgvCelebridadesSearch.MultiSelect = false;
            dgvCelebridadesSearch.Name = "dgvCelebridadesSearch";
            dgvCelebridadesSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCelebridadesSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCelebridadesSearch.RowHeadersVisible = false;
            dgvCelebridadesSearch.RowHeadersWidth = 51;
            dgvCelebridadesSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCelebridadesSearch.RowTemplate.Height = 29;
            dgvCelebridadesSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCelebridadesSearch.Size = new Size(1094, 540);
            dgvCelebridadesSearch.TabIndex = 6;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.DataPropertyName = "Nome";
            Título.FillWeight = 200F;
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.ReadOnly = true;
            // 
            // Sinopse
            // 
            Sinopse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sinopse.DataPropertyName = "Sinopse";
            Sinopse.FillWeight = 300F;
            Sinopse.HeaderText = "Sinopse";
            Sinopse.MinimumWidth = 6;
            Sinopse.Name = "Sinopse";
            Sinopse.ReadOnly = true;
            // 
            // DataLançamento
            // 
            DataLançamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataLançamento.DataPropertyName = "DataLancamento";
            DataLançamento.FillWeight = 80F;
            DataLançamento.HeaderText = "Data de Lançamento";
            DataLançamento.MinimumWidth = 6;
            DataLançamento.Name = "DataLançamento";
            DataLançamento.ReadOnly = true;
            // 
            // Duração
            // 
            Duração.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Duração.DataPropertyName = "Duração";
            Duração.FillWeight = 80F;
            Duração.HeaderText = "Duração";
            Duração.MinimumWidth = 6;
            Duração.Name = "Duração";
            Duração.ReadOnly = true;
            // 
            // frmCelebridade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 749);
            Controls.Add(nudPágina);
            Controls.Add(cbbTipos);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(dgvCelebridadesSearch);
            Name = "frmCelebridade";
            Text = "Celebridades";
            ((System.ComponentModel.ISupportInitialize)nudPágina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCelebridadesSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudPágina;
        private ComboBox cbbTipos;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView dgvCelebridadesSearch;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn DataLançamento;
        private DataGridViewTextBoxColumn Duração;
    }
}