namespace TVOrganizer.Fronteira
{
    partial class frmProgramaConcluido
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
            dgvConcluidos = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Comentário = new DataGridViewTextBoxColumn();
            Gênero = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnMenu = new Button();
            btnComentar = new Button();
            btnAssistir = new Button();
            btnDarNota = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConcluidos).BeginInit();
            SuspendLayout();
            // 
            // dgvConcluidos
            // 
            dgvConcluidos.AllowUserToAddRows = false;
            dgvConcluidos.AllowUserToDeleteRows = false;
            dgvConcluidos.AllowUserToResizeColumns = false;
            dgvConcluidos.AllowUserToResizeRows = false;
            dgvConcluidos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConcluidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcluidos.Columns.AddRange(new DataGridViewColumn[] { Título, Tipo, Sinopse, Nota, Comentário, Gênero });
            dgvConcluidos.Location = new Point(-2, 124);
            dgvConcluidos.MultiSelect = false;
            dgvConcluidos.Name = "dgvConcluidos";
            dgvConcluidos.ReadOnly = true;
            dgvConcluidos.RowHeadersVisible = false;
            dgvConcluidos.RowHeadersWidth = 51;
            dgvConcluidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvConcluidos.RowTemplate.Height = 29;
            dgvConcluidos.ScrollBars = ScrollBars.Vertical;
            dgvConcluidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConcluidos.Size = new Size(865, 389);
            dgvConcluidos.TabIndex = 0;
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
            label1.Location = new Point(258, 37);
            label1.Name = "label1";
            label1.Size = new Size(379, 46);
            label1.TabIndex = 1;
            label1.Text = "Programas Concluídos";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(23, 539);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(134, 35);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu Principal";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(701, 539);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(134, 35);
            btnComentar.TabIndex = 3;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            // 
            // btnAssistir
            // 
            btnAssistir.Location = new Point(232, 539);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(156, 35);
            btnAssistir.TabIndex = 4;
            btnAssistir.Text = "Marcar Para Assistir";
            btnAssistir.UseVisualStyleBackColor = true;
            btnAssistir.Click += btnAssistir_Click;
            // 
            // btnDarNota
            // 
            btnDarNota.Location = new Point(474, 539);
            btnDarNota.Name = "btnDarNota";
            btnDarNota.Size = new Size(134, 35);
            btnDarNota.TabIndex = 5;
            btnDarNota.Text = "Dar Nota";
            btnDarNota.UseVisualStyleBackColor = true;
            // 
            // frmProgramaConcluido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 586);
            Controls.Add(btnDarNota);
            Controls.Add(btnAssistir);
            Controls.Add(btnComentar);
            Controls.Add(btnMenu);
            Controls.Add(label1);
            Controls.Add(dgvConcluidos);
            MaximizeBox = false;
            Name = "frmProgramaConcluido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programas Concluídos";
            Load += F_ProgramaConcluido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConcluidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConcluidos;
        private Label label1;
        private Button btnMenu;
        private Button btnComentar;
        private Button btnAssistir;
        private Button btnDarNota;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn Comentário;
        private DataGridViewTextBoxColumn Gênero;
    }
}