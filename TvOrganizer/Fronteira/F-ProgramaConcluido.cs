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
using TVOrganizer.Fronteira;

namespace TVOrganizer.Fronteira
{
    public partial class frmProgramaConcluido : Form
    {
        internal List<Programar> Concluídos = null;
        public frmProgramaConcluido()
        {
            InitializeComponent();
        }

        private void F_ProgramaConcluido_Load(object sender, EventArgs e)
        {
            PreencherTabela();
        }

        private void PreencherTabela()
        {
            List<Programar> programasCarregados = C_ProgramaConcluído.RetornarConcluídos();
            Concluídos = programasCarregados;
            FormatarColunas(programasCarregados);
        }

        private void FormatarColunas(List<Programar> programas)
        {
            foreach (Programar programar in programas)
            {
                string tipo = programar.IdEpConcluidos == null ? "Filme" : "Série";
                string generos = "";
                foreach (string genero in programar.Programa.Gênero)
                {
                    generos += genero + Environment.NewLine;
                }
                string[] linha = { programar.Programa.Nome, tipo, programar.Programa.Sinopse, programar.Nota.ToString(),
                programar.Comentario, generos };
                dgvConcluidos.Rows.Add(linha);
            }
        }


        private bool Confirmar(string msg)
        {
            return MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            if (!Confirmar("Deseja marcar este programa como Para Assistir?"))
            {
                return;
            }
            DataGridViewRow linhaSelecionada = dgvConcluidos.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = Concluídos[index];

            C_Assistindo.ProgramarAssistir(programar);

            PreencherTabela();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmTelaProgramas frmTelaProgramas = new frmTelaProgramas();
            frmTelaProgramas.Show();
            this.Hide();
        }

        private void dgvConcluidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvConcluidos.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Programar programar = Concluídos[index];

            frmAvaliar frmAvaliar = new frmAvaliar();
            frmAvaliar.CarregarAvaliação(programar);
            frmAvaliar.ShowDialog();
            this.Hide();
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            if (Confirmar("Deseja Favoritar este programa?"))
            {
                DataGridViewRow linhaSelecionada = dgvConcluidos.SelectedRows[0];
                int index = linhaSelecionada.Index;
                Programar programar = Concluídos[index];

                C_Favoritos.FavoritarPrograma(programar);
            }
        }

        private void dgvConcluidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
