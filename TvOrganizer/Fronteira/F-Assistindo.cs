using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVOrganizer.Controle;
using TVOrganizer.Entidade;

namespace TVOrganizer.Fronteira
{
    public partial class frmAssistindo : Form
    {
        internal List<Programar> programados = null;
        public frmAssistindo()
        {
            InitializeComponent();
        }

        private void F_Assistindo_Load(object sender, EventArgs e)
        {
            CarregarProgramas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarProgramas()
        {
            List<Programar> programasCarregados = C_Assistindo.retornarProgramados();
            programados = programasCarregados;
            FormatarColunas(programasCarregados);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaProgramas fr = new frmTelaProgramas();
            fr.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
        private void FormatarColunas(List<Programar> dados)
        {
            foreach (Programar programar in dados)
            {
                string tipo = programar.IdEpConcluidos == null ? "Filme" : "Série";
                string[] linha = { programar.Programa.Nome, tipo, programar.Data.ToString(), programar.Hora.ToString() };
                dgvProgramas.Rows.Add(linha);

            }
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvProgramas.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = programados[index];

        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {
            if (!(Confirmar("Deseja marcar este programa como concluído?")))
            {
                return;
            }
            DataGridViewRow linhaSelecionada = dgvProgramas.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = programados[index];

            C_ProgramaConcluído.ConcluirPrograma(programar);

            dgvProgramas.Refresh();
        }

        private bool Confirmar(string msg)
        {
            return MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }
    }
}
}
