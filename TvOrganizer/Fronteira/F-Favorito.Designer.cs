namespace TVOrganizer.Fronteira
{
    partial class frmFavorito
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
            dgvFavoritos = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Comentário = new DataGridViewTextBoxColumn();
            Gênero = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnVoltar = new Button();
            btnFavorito = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).BeginInit();
            SuspendLayout();
            // 
            // dgvFavoritos
            // 
            dgvFavoritos.AllowUserToAddRows = false;
            dgvFavoritos.AllowUserToDeleteRows = false;
            dgvFavoritos.AllowUserToResizeColumns = false;
            dgvFavoritos.AllowUserToResizeRows = false;
            dgvFavoritos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFavoritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFavoritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFavoritos.Columns.AddRange(new DataGridViewColumn[] { Título, Tipo, Sinopse, Nota, Comentário, Gênero });
            dgvFavoritos.Location = new Point(1, 78);
            dgvFavoritos.MultiSelect = false;
            dgvFavoritos.Name = "dgvFavoritos";
            dgvFavoritos.ReadOnly = true;
            dgvFavoritos.RowHeadersVisible = false;
            dgvFavoritos.RowHeadersWidth = 51;
            dgvFavoritos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFavoritos.RowTemplate.Height = 29;
            dgvFavoritos.ScrollBars = ScrollBars.Vertical;
            dgvFavoritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavoritos.Size = new Size(999, 491);
            dgvFavoritos.TabIndex = 1;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.FillWeight = 150F;
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Sinopse
            // 
            Sinopse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sinopse.HeaderText = "Sinopse";
            Sinopse.MinimumWidth = 6;
            Sinopse.Name = "Sinopse";
            Sinopse.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // Comentário
            // 
            Comentário.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Comentário.FillWeight = 300F;
            Comentário.HeaderText = "Comentário";
            Comentário.MinimumWidth = 6;
            Comentário.Name = "Comentário";
            Comentário.ReadOnly = true;
            // 
            // Gênero
            // 
            Gênero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gênero.HeaderText = "Gênero";
            Gênero.MinimumWidth = 6;
            Gênero.Name = "Gênero";
            Gênero.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 46);
            label1.TabIndex = 2;
            label1.Text = "Favoritos";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(36, 575);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(155, 42);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnFavorito
            // 
            btnFavorito.Location = new Point(796, 575);
            btnFavorito.Name = "btnFavorito";
            btnFavorito.Size = new Size(154, 42);
            btnFavorito.TabIndex = 4;
            btnFavorito.Text = "Desmarcar Favorito";
            btnFavorito.UseVisualStyleBackColor = true;
            btnFavorito.Click += btnFavorito_Click;
            // 
            // frmFavorito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 626);
            Controls.Add(btnFavorito);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(dgvFavoritos);
            MaximizeBox = false;
            Name = "frmFavorito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favoritos";
            Load += frmFavorito_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFavoritos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFavoritos;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn Comentário;
        private DataGridViewTextBoxColumn Gênero;
        private Label label1;
        private Button btnVoltar;
        private Button btnFavorito;
    }
}