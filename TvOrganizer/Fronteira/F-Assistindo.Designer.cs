﻿namespace TVOrganizer.Fronteira
{
    partial class frmAssistindo
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvProgramas = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ProxEpisodio = new DataGridViewTextBoxColumn();
            DataProgramada = new DataGridViewTextBoxColumn();
            HoraProgramada = new DataGridViewTextBoxColumn();
            lblAssistir = new Label();
            btnProgramar = new Button();
            btnMarcarConcluido = new Button();
            btnMenu = new Button();
            btnEpisódio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProgramas).BeginInit();
            SuspendLayout();
            // 
            // dgvProgramas
            // 
            dgvProgramas.AllowUserToAddRows = false;
            dgvProgramas.AllowUserToDeleteRows = false;
            dgvProgramas.AllowUserToResizeColumns = false;
            dgvProgramas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgvProgramas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProgramas.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProgramas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProgramas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgramas.Columns.AddRange(new DataGridViewColumn[] { Título, Tipo, ProxEpisodio, DataProgramada, HoraProgramada });
            dgvProgramas.Location = new Point(12, 94);
            dgvProgramas.MultiSelect = false;
            dgvProgramas.Name = "dgvProgramas";
            dgvProgramas.ReadOnly = true;
            dgvProgramas.RowHeadersVisible = false;
            dgvProgramas.RowHeadersWidth = 51;
            dgvProgramas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProgramas.RowTemplate.Height = 29;
            dgvProgramas.ScrollBars = ScrollBars.Vertical;
            dgvProgramas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProgramas.Size = new Size(783, 419);
            dgvProgramas.TabIndex = 0;
            dgvProgramas.CellContentClick += dataGridView1_CellContentClick;
            dgvProgramas.CellContentDoubleClick += dataGridView1_CellContentClick;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Título.DefaultCellStyle = dataGridViewCellStyle3;
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
            // ProxEpisodio
            // 
            ProxEpisodio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProxEpisodio.DataPropertyName = "Episódio";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProxEpisodio.DefaultCellStyle = dataGridViewCellStyle4;
            ProxEpisodio.FillWeight = 36.02498F;
            ProxEpisodio.HeaderText = "Próximo Episódio";
            ProxEpisodio.MinimumWidth = 6;
            ProxEpisodio.Name = "ProxEpisodio";
            ProxEpisodio.ReadOnly = true;
            // 
            // DataProgramada
            // 
            DataProgramada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataProgramada.DataPropertyName = "Data";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataProgramada.DefaultCellStyle = dataGridViewCellStyle5;
            DataProgramada.FillWeight = 36.02498F;
            DataProgramada.HeaderText = "Data Programada";
            DataProgramada.MinimumWidth = 6;
            DataProgramada.Name = "DataProgramada";
            DataProgramada.ReadOnly = true;
            // 
            // HoraProgramada
            // 
            HoraProgramada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoraProgramada.DataPropertyName = "Hora";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.BottomCenter;
            HoraProgramada.DefaultCellStyle = dataGridViewCellStyle6;
            HoraProgramada.FillWeight = 36.02498F;
            HoraProgramada.HeaderText = "Hora Programada";
            HoraProgramada.MinimumWidth = 6;
            HoraProgramada.Name = "HoraProgramada";
            HoraProgramada.ReadOnly = true;
            // 
            // lblAssistir
            // 
            lblAssistir.AutoSize = true;
            lblAssistir.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssistir.Location = new Point(300, 29);
            lblAssistir.Name = "lblAssistir";
            lblAssistir.Size = new Size(208, 46);
            lblAssistir.TabIndex = 1;
            lblAssistir.Text = "Para Assistir";
            lblAssistir.Click += label1_Click;
            // 
            // btnProgramar
            // 
            btnProgramar.Location = new Point(626, 551);
            btnProgramar.Name = "btnProgramar";
            btnProgramar.Size = new Size(150, 30);
            btnProgramar.TabIndex = 3;
            btnProgramar.Text = "Programar";
            btnProgramar.UseVisualStyleBackColor = true;
            btnProgramar.Click += btnProgramar_Click;
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.Location = new Point(422, 551);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(150, 30);
            btnMarcarConcluido.TabIndex = 4;
            btnMarcarConcluido.Text = "Concluir";
            btnMarcarConcluido.UseVisualStyleBackColor = true;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(12, 551);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(150, 30);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu Principal";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEpisódio
            // 
            btnEpisódio.Location = new Point(221, 551);
            btnEpisódio.Name = "btnEpisódio";
            btnEpisódio.Size = new Size(150, 30);
            btnEpisódio.TabIndex = 6;
            btnEpisódio.Text = "Concluir Episódio";
            btnEpisódio.UseVisualStyleBackColor = true;
            // 
            // frmAssistindo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(btnEpisódio);
            Controls.Add(btnMenu);
            Controls.Add(btnMarcarConcluido);
            Controls.Add(btnProgramar);
            Controls.Add(lblAssistir);
            Controls.Add(dgvProgramas);
            MaximizeBox = false;
            Name = "frmAssistindo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Assistindo";
            Load += F_Assistindo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProgramas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProgramas;
        private Label lblAssistir;
        private Button btnProgramar;
        private Button btnMarcarConcluido;
        private Button btnMenu;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn ProxEpisodio;
        private DataGridViewTextBoxColumn DataProgramada;
        private DataGridViewTextBoxColumn HoraProgramada;
        private Button btnEpisódio;
    }
}