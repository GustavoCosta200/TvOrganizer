using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvOrganizer.Fronteira;
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
            dgvProgramas.Rows.Clear();
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

                if (programar.IdEpConcluidos != null)
                {
                    string proxEp = C_Assistindo.RetornarProximoEpisodio(programar);
                    string[] linha = { programar.Programa.Nome, programar.Programa.Sinopse, tipo, programar.Data, programar.Hora, proxEp };
                    dgvProgramas.Rows.Add(linha);
                }
                else
                {
                    string[] linha = { programar.Programa.Nome, programar.Programa.Sinopse, tipo, programar.Data, programar.Hora };
                    dgvProgramas.Rows.Add(linha);
                }
            }
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvProgramas.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = programados[index];

            frmProgramar frmProgramar = new frmProgramar();
            frmProgramar.CarregarCampos(programar);
            frmProgramar.Show();
            this.Hide();
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

            CarregarProgramas();
        }

        private bool Confirmar(string msg)
        {
            return MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }

        private void btnEpisódio_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvProgramas.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = programados[index];

            if (programar.IdEpConcluidos != null)
            {
                frmEpisódios frmEpisódios = new frmEpisódios();
                frmEpisódios.CarregarDadosAssistindo(programar);
                frmEpisódios.ShowDialog();

                CarregarProgramas();

            }
            else
            {
                MessageBox.Show("Selecione uma Série!", "Opção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

