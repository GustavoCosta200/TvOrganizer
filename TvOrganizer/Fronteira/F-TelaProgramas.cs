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
using TvOrganizer.APIControl;
using Newtonsoft.Json;
using TvOrganizer.Exception;
using Refit;
using System.Runtime.CompilerServices;

namespace TVOrganizer.Fronteira
{
    public partial class frmTelaProgramas : Form
    {
        static Programa ProgramaSelecionado = null;
        string tipoPesquisado = null;
        public frmTelaProgramas()
        {
            InitializeComponent();
        }

        private void F_TelaProgramas_Load(object sender, EventArgs e)
        {
            //Carregamento inicial da tabela
            cbbTipos.SelectedItem = "Filme";
            tipoPesquisado = "Filme";
            CarregarProgramasPopulares();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvTelaProgramas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carregar()
        {
            //Carrega de acordo com o tipo selecionado na tabela e seta esse tipo na variável de controle
            if (cbbTipos.Text == "Filme")
            {
                CarregarFilmes();
                tipoPesquisado = "Filme";
            }
            else if (cbbTipos.Text == "Série")
            {
                CarregarSérie();
                tipoPesquisado = "Série";
            }
        }

        private async void CarregarProgramasPopulares()
        {
            try
            {
                //Pedido à API para filmes populares
                var popularMovieRequest = RestService.For<IGetPopular>("https://api.themoviedb.org");
                var movieList = await popularMovieRequest.GetAdressAsync(nudPágina.Value.ToString());
                dynamic movies = JsonConvert.DeserializeObject(movieList);

                int pageMax = movies.total_pages;

                nudPágina.Maximum = pageMax;

                PreencherCamposFilmes(movies);

            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IOException)
            {
            }
        }

        private async void CarregarFilmes()
        {
            try
            {
                //Pedido à API para filme pesquisado
                var popularMovieRequest = RestService.For<ISearchMovie>("https://api.themoviedb.org");
                var movieList = await popularMovieRequest.GetAdressAsync(txtPesquisa.Text.Trim(), nudPágina.Value.ToString());
                dynamic movies = JsonConvert.DeserializeObject(movieList);

                int pageMax = movies.total_pages;

                nudPágina.Maximum = pageMax;

                PreencherCamposFilmes(movies);


            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IOException)
            {
            }
        }

        private async void CarregarSérie()
        {
            try
            {
                //Pedido à API para série pesquisada
                var seriesRequesy = RestService.For<ISearchSeries>("https://api.themoviedb.org");
                var seriesList = await seriesRequesy.GetAdressAsync(txtPesquisa.Text.Trim(), nudPágina.Value.ToString());
                dynamic series = JsonConvert.DeserializeObject(seriesList);

                int pageMax = series.total_pages;

                nudPágina.Maximum = pageMax;

                PreencherCamposSeries(series);

            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (IOException)
            {
            }
        }


        private void PreencherCamposFilmes(dynamic movies)
        {
            var results = movies.results;
            //Preenche os campos da tabela com classes programas geradas
            var respProgramas = C_Programa.RetornarFilmes(results);

            dgvTelaProgramas.DataSource = respProgramas;
            dgvTelaProgramas.AutoGenerateColumns = false;
            dgvTelaProgramas.Refresh();
            FormatarColunas();
        }

        private void PreencherCamposSeries(dynamic series)
        {
            var results = series.results;

            var respProgramas = C_Programa.RetornarSéries(results);

            dgvTelaProgramas.DataSource = respProgramas;
            dgvTelaProgramas.AutoGenerateColumns = false;
            dgvTelaProgramas.Refresh();
            FormatarColunas();
        }

        private void FormatarColunas()
        {
            dgvTelaProgramas.Columns["Título"].Visible = true;
            dgvTelaProgramas.Columns["Sinopse"].Visible = true;
            dgvTelaProgramas.Columns["DataLançamento"].Visible = true;
            dgvTelaProgramas.Columns["Duração"].Visible = false;
            dgvTelaProgramas.Columns["Nota"].Visible = false;
            dgvTelaProgramas.Columns["Imagem"].Visible = false;
            //dgvTelaProgramas.Columns["Gênero"].Visible = true;
            dgvTelaProgramas.Columns["Id"].Visible = true;
            //dgvTelaProgramas.Columns["Tipo"].Visible = false;
        }

        //Atualiza a página com o valor selecionado da caixa
        private void nudPágina_ValueChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Trim().Length == 0)
            {
                CarregarProgramasPopulares();
            }
            else
            {
                Carregar();
            }
        }
        //Realiza a pesquisa com o valor na caixa de texto
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            nudPágina.Value = 1;
            Carregar();
        }

        private void dgvTelaProgramas_DoubleClick(object sender, EventArgs e)
        {
            VerInformações();
        }

        private void btnVerInformações_Click(object sender, EventArgs e)
        {
            VerInformações();
        }
        //Abre janela de Informações
        private void VerInformações()
        {
            DataGridViewRow linhaSelecionada = dgvTelaProgramas.SelectedRows[0];
            if (this.tipoPesquisado == "Filme")
            {
                ProgramaSelecionado = linhaSelecionada.DataBoundItem as Filme;
            }
            else if (this.tipoPesquisado == "Série")
            {
                ProgramaSelecionado = linhaSelecionada.DataBoundItem as Série;
            }

            frmPrograma frmprograma = new frmPrograma();
            frmprograma.CarregarDadosPrograma(ProgramaSelecionado);
            frmprograma.Show();
            this.Hide();
        }

        private void btnAssistindo_Click(object sender, EventArgs e)
        {
            frmAssistindo frmAssistindo = new frmAssistindo();
            frmAssistindo.Show();
            this.Hide();
        }

        private void btnConcluído_Click(object sender, EventArgs e)
        {
            frmProgramaConcluido frm = new frmProgramaConcluido();
            frm.Show();
            this.Hide();
        }

        private void cbbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipos.SelectedItem == "Pessoa")
            {
                frmCelebridade frm = new frmCelebridade();
                frm.Show();
                this.Hide();
            }
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            frmFavorito frm = new frmFavorito();
            frm.Show();
            this.Hide();
        }
    }
}
