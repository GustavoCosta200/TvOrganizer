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
    public partial class frmFavorito : Form
    {
        internal List<Programar> Favoritos = null;
        public frmFavorito()
        {
            InitializeComponent();
        }

        private void frmFavorito_Load(object sender, EventArgs e)
        {
            PreencherTabela();
        }

        private void PreencherTabela()
        {
            dgvFavoritos.Rows.Clear();
            List<Programar> programasCarregados = C_Favoritos.RetornarFavoritos();
            Favoritos = programasCarregados;
            FormatarColunas(Favoritos);
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
                dgvFavoritos.Rows.Add(linha);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaProgramas frmTelaProgramas = new frmTelaProgramas();
            frmTelaProgramas.Show();
            this.Hide();
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja desmacara este programa como favorito?", "Desmarcar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DataGridViewRow linhaSelecionada = dgvFavoritos.SelectedRows[0];
                int index = linhaSelecionada.Index;
                Programar programar = Favoritos[index];

                C_Favoritos.DesfavoritarPrograma(programar);
                PreencherTabela();
            }
        }
    }
}
