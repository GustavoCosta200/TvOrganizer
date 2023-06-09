using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvOrganizer.APIControl;
using TVOrganizer.Controle;
using TVOrganizer.Entidade;

namespace TVOrganizer.Fronteira
{
    public partial class frmEpisódios : Form
    {
        internal Programar programar = null;
        internal List<Episodio> episodios = null;
        internal string anterior = null;
        public frmEpisódios()
        {
            InitializeComponent();
        }

        private void F_Episodios_Load(object sender, EventArgs e)
        {
        }

        internal void CarregarDadosInformações(string name, int idSérie)
        {
            lblNome.Text = name;
            string anterior = "Programa";
            btnConcluir.Enabled = false;
            CarregarDadosEpisódios(idSérie);


        }
        internal void CarregarDadosAssistindo(Programar programar)
        {
            this.programar = programar;
            episodios = programar.IdEpConcluidos;
            lblNome.Text = programar.Programa.Nome;
            string anterior = "Assistido";
            CarregarDadosEpisódios(programar.Programa.Id);

        }

        private async void CarregarDadosEpisódios(int idSérie)
        {
            var movieRequest = RestService.For<ISeriesInformation>("https://api.themoviedb.org");
            var movieSeries = await movieRequest.GetAdressAsync(idSérie.ToString());
            dynamic movie = JsonConvert.DeserializeObject(movieSeries);

            dynamic seasons = movie.seasons;

            foreach (dynamic season in seasons)
            {
                int seasonNumber = season.season_number;
                var seasonRequest = RestService.For<ISeasonInformation>("https://api.themoviedb.org");
                var seriesList = await seasonRequest.GetAdressAsync(idSérie.ToString(), seasonNumber.ToString());
                dynamic seasonGet = JsonConvert.DeserializeObject(seriesList);

                dynamic episodes = seasonGet.episodes;

                foreach (dynamic episodio in episodes)
                {
                    string titulo = episodio.name;
                    string sinopse = episodio.overview;
                    int nepisodio = episodio.episode_number;
                    int ntemporada = episodio.season_number;
                    string id = nepisodio.ToString() + "/" + ntemporada.ToString();

                    string[] linha = { titulo, sinopse, nepisodio.ToString(), ntemporada.ToString(), id };
                    dgvEpisódios.Rows.Add(linha);
                }
            }
        }


        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void dgvEpisódios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvEpisódios.SelectedRows[0];
            int index = linhaSelecionada.Index;
            Episodio episodio = episodios[index];

            C_Episodio.ConcluirEpisodio(programar, episodio);

            dgvEpisódios.Rows.Clear();

            CarregarDadosAssistindo(programar);
        }

    }
}
