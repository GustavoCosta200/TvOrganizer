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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCelebridade));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nudPágina = new NumericUpDown();
            btnPesquisar = new Button();
            imageList1 = new ImageList(components);
            txtPesquisa = new TextBox();
            dgvCelebridadesSearch = new DataGridView();
            lblCelebridades = new Label();
            btnVoltar = new Button();
            Título = new DataGridViewTextBoxColumn();
            Função = new DataGridViewTextBoxColumn();
            Nascimento = new DataGridViewTextBoxColumn();
            LocalNascimento = new DataGridViewTextBoxColumn();
            Programas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudPágina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCelebridadesSearch).BeginInit();
            SuspendLayout();
            // 
            // nudPágina
            // 
            nudPágina.Location = new Point(923, 107);
            nudPágina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPágina.Name = "nudPágina";
            nudPágina.Size = new Size(158, 27);
            nudPágina.TabIndex = 9;
            nudPágina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudPágina.ValueChanged += nudPágina_ValueChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(424, 107);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.RightToLeft = RightToLeft.No;
            btnPesquisar.Size = new Size(45, 31);
            btnPesquisar.TabIndex = 7;
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
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(12, 107);
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
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgvCelebridadesSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCelebridadesSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvCelebridadesSearch.BackgroundColor = SystemColors.ActiveCaption;
            dgvCelebridadesSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCelebridadesSearch.Columns.AddRange(new DataGridViewColumn[] { Título, Função, Nascimento, LocalNascimento, Programas });
            dgvCelebridadesSearch.Location = new Point(5, 143);
            dgvCelebridadesSearch.MultiSelect = false;
            dgvCelebridadesSearch.Name = "dgvCelebridadesSearch";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCelebridadesSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCelebridadesSearch.RowHeadersVisible = false;
            dgvCelebridadesSearch.RowHeadersWidth = 51;
            dgvCelebridadesSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCelebridadesSearch.RowTemplate.Height = 29;
            dgvCelebridadesSearch.ScrollBars = ScrollBars.Vertical;
            dgvCelebridadesSearch.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCelebridadesSearch.Size = new Size(1086, 540);
            dgvCelebridadesSearch.TabIndex = 6;
            dgvCelebridadesSearch.CellContentClick += dgvCelebridadesSearch_CellContentClick;
            // 
            // lblCelebridades
            // 
            lblCelebridades.AutoSize = true;
            lblCelebridades.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCelebridades.Location = new Point(424, 22);
            lblCelebridades.Name = "lblCelebridades";
            lblCelebridades.Size = new Size(225, 46);
            lblCelebridades.TabIndex = 10;
            lblCelebridades.Text = "Celebridades";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 700);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(121, 46);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.DataPropertyName = "Nome";
            Título.FillWeight = 180F;
            Título.HeaderText = "Nome";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            // 
            // Função
            // 
            Função.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Função.HeaderText = "Função";
            Função.MinimumWidth = 6;
            Função.Name = "Função";
            // 
            // Nascimento
            // 
            Nascimento.HeaderText = "Nascimento";
            Nascimento.MinimumWidth = 6;
            Nascimento.Name = "Nascimento";
            Nascimento.Width = 125;
            // 
            // LocalNascimento
            // 
            LocalNascimento.HeaderText = "Local de Nascimento";
            LocalNascimento.MinimumWidth = 6;
            LocalNascimento.Name = "LocalNascimento";
            LocalNascimento.Width = 125;
            // 
            // Programas
            // 
            Programas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Programas.DataPropertyName = "Sinopse";
            Programas.FillWeight = 300F;
            Programas.HeaderText = "Programas";
            Programas.MinimumWidth = 6;
            Programas.Name = "Programas";
            Programas.Resizable = DataGridViewTriState.True;
            // 
            // frmCelebridade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 749);
            Controls.Add(btnVoltar);
            Controls.Add(lblCelebridades);
            Controls.Add(nudPágina);
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
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView dgvCelebridadesSearch;
        private ImageList imageList1;
        private Label lblCelebridades;
        private Button btnVoltar;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Função;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewTextBoxColumn LocalNascimento;
        private DataGridViewTextBoxColumn Programas;
    }
}