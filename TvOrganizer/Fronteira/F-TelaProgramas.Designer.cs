namespace TVOrganizer.Fronteira
{
    partial class frmTelaProgramas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaProgramas));
            dgvTelaProgramas = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            DataLançamento = new DataGridViewTextBoxColumn();
            Duração = new DataGridViewTextBoxColumn();
            lblProgramas = new Label();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            cbbTipos = new ComboBox();
            nudPágina = new NumericUpDown();
            btnAssistindo = new Button();
            btnConcluído = new Button();
            btnFavorito = new Button();
            btnVerInformações = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTelaProgramas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPágina).BeginInit();
            SuspendLayout();
            // 
            // dgvTelaProgramas
            // 
            dgvTelaProgramas.AllowUserToAddRows = false;
            dgvTelaProgramas.AllowUserToDeleteRows = false;
            dgvTelaProgramas.AllowUserToOrderColumns = true;
            dgvTelaProgramas.AllowUserToResizeColumns = false;
            dgvTelaProgramas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgvTelaProgramas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTelaProgramas.BackgroundColor = SystemColors.ActiveCaption;
            dgvTelaProgramas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelaProgramas.Columns.AddRange(new DataGridViewColumn[] { Título, Sinopse, DataLançamento, Duração });
            dgvTelaProgramas.Location = new Point(0, 124);
            dgvTelaProgramas.MultiSelect = false;
            dgvTelaProgramas.Name = "dgvTelaProgramas";
            dgvTelaProgramas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTelaProgramas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTelaProgramas.RowHeadersVisible = false;
            dgvTelaProgramas.RowHeadersWidth = 51;
            dgvTelaProgramas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTelaProgramas.RowTemplate.Height = 29;
            dgvTelaProgramas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelaProgramas.Size = new Size(1094, 540);
            dgvTelaProgramas.TabIndex = 0;
            dgvTelaProgramas.CellContentClick += dgvTelaProgramas_CellContentClick;
            dgvTelaProgramas.CellContentDoubleClick += dgvTelaProgramas_CellContentClick;
            dgvTelaProgramas.DoubleClick += dgvTelaProgramas_DoubleClick;
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
            // lblProgramas
            // 
            lblProgramas.AutoSize = true;
            lblProgramas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgramas.Location = new Point(472, 9);
            lblProgramas.Name = "lblProgramas";
            lblProgramas.Size = new Size(158, 38);
            lblProgramas.TabIndex = 1;
            lblProgramas.Text = "Programas";
            lblProgramas.Click += label1_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(0, 87);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar...";
            txtPesquisa.Size = new Size(406, 30);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(585, 87);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.RightToLeft = RightToLeft.No;
            btnPesquisar.Size = new Size(45, 31);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "64673.png");
            // 
            // cbbTipos
            // 
            cbbTipos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbbTipos.FormattingEnabled = true;
            cbbTipos.Items.AddRange(new object[] { "Filme", "Série", "Pessoa" });
            cbbTipos.Location = new Point(424, 87);
            cbbTipos.Name = "cbbTipos";
            cbbTipos.Size = new Size(155, 31);
            cbbTipos.TabIndex = 3;
            // 
            // nudPágina
            // 
            nudPágina.Location = new Point(925, 87);
            nudPágina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPágina.Name = "nudPágina";
            nudPágina.Size = new Size(158, 27);
            nudPágina.TabIndex = 4;
            nudPágina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPágina.ValueChanged += nudPágina_ValueChanged;
            // 
            // btnAssistindo
            // 
            btnAssistindo.Location = new Point(602, 682);
            btnAssistindo.Name = "btnAssistindo";
            btnAssistindo.Size = new Size(144, 49);
            btnAssistindo.TabIndex = 5;
            btnAssistindo.Text = "Menu Assistindo";
            btnAssistindo.UseVisualStyleBackColor = true;
            btnAssistindo.Click += btnAssistindo_Click;
            // 
            // btnConcluído
            // 
            btnConcluído.Location = new Point(319, 682);
            btnConcluído.Name = "btnConcluído";
            btnConcluído.Size = new Size(140, 49);
            btnConcluído.TabIndex = 6;
            btnConcluído.Text = "Menu Concluído";
            btnConcluído.UseVisualStyleBackColor = true;
            btnConcluído.Click += btnConcluído_Click;
            // 
            // btnFavorito
            // 
            btnFavorito.Location = new Point(56, 682);
            btnFavorito.Name = "btnFavorito";
            btnFavorito.Size = new Size(135, 49);
            btnFavorito.TabIndex = 7;
            btnFavorito.Text = "Menu Favorito";
            btnFavorito.UseVisualStyleBackColor = true;
            // 
            // btnVerInformações
            // 
            btnVerInformações.Location = new Point(904, 682);
            btnVerInformações.Name = "btnVerInformações";
            btnVerInformações.Size = new Size(124, 49);
            btnVerInformações.TabIndex = 8;
            btnVerInformações.Text = "Ver Informações";
            btnVerInformações.UseVisualStyleBackColor = true;
            btnVerInformações.Click += btnVerInformações_Click;
            // 
            // frmTelaProgramas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 743);
            Controls.Add(btnVerInformações);
            Controls.Add(btnFavorito);
            Controls.Add(btnConcluído);
            Controls.Add(btnAssistindo);
            Controls.Add(nudPágina);
            Controls.Add(cbbTipos);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Controls.Add(lblProgramas);
            Controls.Add(dgvTelaProgramas);
            MaximizeBox = false;
            Name = "frmTelaProgramas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "F_TelaProgramas";
            Load += F_TelaProgramas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTelaProgramas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPágina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTelaProgramas;
        private Label lblProgramas;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private ComboBox cbbTipos;
        private ImageList imageList1;
        private NumericUpDown nudPágina;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn DataLançamento;
        private DataGridViewTextBoxColumn Duração;
        private Button btnAssistindo;
        private Button btnConcluído;
        private Button btnFavorito;
        private Button btnVerInformações;
    }
}