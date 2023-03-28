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
            else if (cbbTipos.Text == "Celebridade")
            {
                CarregarPessoa();
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

        private async void CarregarPessoa()
        {
            try
            {
                //Pedido à API para pessoas populares
                var personRequest = RestService.For<ISearchPerson>("https://api.themoviedb.org");
                var personList = await personRequest.GetAdressAsync(txtPesquisa.Text.Trim(), nudPágina.Value.ToString());
                dynamic persons = JsonConvert.DeserializeObject(personList);

                int pageMax = persons.total_pages;

                nudPágina.Maximum = pageMax;
                PreencherCamposPessoas(persons);
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

            List<Programa> respProgramas = new List<Programa>();

            foreach (var item in results)
            {
                string title = item.title;
                string overview = item.overview;
                string release_date = item.release_date;
                int id = item.id;
                int[] genres = item.genres;

                respProgramas.Add(new Filme(title, overview, release_date, id, genres));
            }

            dgvTelaProgramas.DataSource = respProgramas;
            dgvTelaProgramas.AutoGenerateColumns = false;
            dgvTelaProgramas.Refresh();
            FormatarColunas();
        }

        private void PreencherCamposSeries(dynamic series)
        {
            var results = series.results;
            List<Programa> respProgramas = new List<Programa>();
            foreach (var item in results)
            {
                string title = item.name;
                string overview = item.overview;
                string release_date = item.first_air_date;
                int id = item.id;

                respProgramas.Add(new Série(title, overview, release_date, id));
            }

            dgvTelaProgramas.DataSource = respProgramas;
            dgvTelaProgramas.AutoGenerateColumns = false;
            dgvTelaProgramas.Refresh();
            FormatarColunas();
        }

        private void PreencherCamposPessoas(dynamic pessoas)
        {
            var results = pessoas.results;
            List<Celebridade> respProgramas = new List<Celebridade>();
            foreach (var item in results)
            {
                string title = item.name;
                int id = item.id;
                respProgramas.Add(new Celebridade(title, id));
            }

            dgvTelaProgramas.DataSource = respProgramas;
            dgvTelaProgramas.AutoGenerateColumns = true;
            dgvTelaProgramas.Refresh();
            FormatarColunasPessoas();
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

        private void FormatarColunasPessoas()
        {
            dgvTelaProgramas.Columns["Nome"].Visible = true;
            dgvTelaProgramas.Columns["Idade"].Visible = false;
            dgvTelaProgramas.Columns["Funcao"].Visible = false;
            dgvTelaProgramas.Columns["Foto"].Visible = false;
            dgvTelaProgramas.Columns["Programas"].Visible = false;
            dgvTelaProgramas.Columns["Id"].Visible = true;
        }

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            nudPágina.Value = 1;
            Carregar();
        }

        private void dgvTelaProgramas_DoubleClick(object sender, EventArgs e)
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
            frmprograma.ShowDialog();
            this.Hide();
        }
    }
}
