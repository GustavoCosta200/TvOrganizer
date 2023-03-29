using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVOrganizer.Entidade;
using TVOrganizer.Controle;
using TvOrganizer.APIControl;
using Newtonsoft.Json;
using Refit;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace TVOrganizer.Fronteira
{
    public partial class frmPrograma : Form
    {
        private dynamic programa = null;
        private string tipo = null;
        public frmPrograma()
        {
            InitializeComponent();
        }

        private void frmPrograma_Load(object sender, EventArgs e)
        {

        }

        internal void CarregarDadosPrograma(Programa programa)
        {
            int id = (int)programa.Id;

            if (programa is Série)
            {
                CarregarDadosSérie(id);
                tipo = "Série";
            }
            else if (programa is Filme)
            {
                CarregarDadosFilme(id);
                tipo = "Filme";
            }
        }

        private async void CarregarDadosFilme(int id)
        {
            //Procura os dados do filme na API com o id
            var movieRequest = RestService.For<IMovieInformation>("https://api.themoviedb.org");
            var movieSeries = await movieRequest.GetAdressAsync(id.ToString());
            dynamic movie = JsonConvert.DeserializeObject(movieSeries);

            this.programa = movie;

            //Formata os dados dos labels
            lblTítulo.Text = movie.title;
            lblSinopse.Text = movie.overview;
            lblNota.Text = lblNota.Text + movie.vote_average;
            string DataLancamento = "";
            try
            {
                string release_date = movie.release_date;
                DateTime data = DateTime.ParseExact(release_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DataLancamento = data.ToString("dd-MM-yyyy");
            }
            catch (ArgumentNullException)
            {
                DataLancamento = "-";
            }
            catch (FormatException)
            {
                DataLancamento = "-";
            }
            lblDataLançamento.Text = DataLancamento;
            lblDuração.Text = lblDuração.Text + movie.runtime.ToString() + "min";
            lblNumEp.Enabled = false;
            lblStatus.Enabled = false;
            lblNumTemp.Enabled = false;
            foreach (var item in movie.genres)
            {
                ltbGêneros.Items.Add(item.name);
            }
            btnEpisódios.Enabled = false;
            var imagePath = movie.poster_path;

            ptbPoster.Load("https://www.themoviedb.org/t/p/w220_and_h330_face" + imagePath);

        }

        private async void CarregarDadosSérie(int id)
        {
            //Procura os dados do filme na API com o id
            var movieRequest = RestService.For<ISeriesInformation>("https://api.themoviedb.org");
            var movieSeries = await movieRequest.GetAdressAsync(id.ToString());
            dynamic movie = JsonConvert.DeserializeObject(movieSeries);

            this.programa = movie;

            //Formata os dados dos labels
            lblTítulo.Text = movie.name;
            lblSinopse.Text = movie.overview;
            lblNota.Text = lblNota.Text + movie.vote_average;
            string DataLancamento = "";
            try
            {
                string release_date = movie.first_air_date;
                DateTime data = DateTime.ParseExact(release_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DataLancamento = data.ToString("dd-MM-yyyy");
            }
            catch (ArgumentNullException)
            {
                DataLancamento = "-";
            }
            catch (FormatException)
            {
                DataLancamento = "-";
            }
            lblDataLançamento.Text = DataLancamento;
            lblNumEp.Text = lblNumEp.Text + movie.number_of_episodes;
            lblStatus.Text = lblStatus.Text + movie.status;
            lblNumTemp.Text = lblNumTemp.Text + movie.number_of_seasons;
            lblDuração.Visible = false;
            foreach (var item in movie.genres)
            {
                ltbGêneros.Items.Add(item.name);
            }
            var imagePath = movie.poster_path;

            ptbPoster.Load("https://www.themoviedb.org/t/p/w220_and_h330_face" + imagePath);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDuração_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTelaProgramas frmtela = new frmTelaProgramas();
            frmtela.Show();
        }

        private void lblNumEp_Click(object sender, EventArgs e)
        {

        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblSinopse_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            if (Confirmar("Deseja marcar este programa como Para Assistir?"))
            {
                C_Assistindo.ProgramarAssistir(programa, tipo);
            }
        }

        private bool Confirmar(string msg)
        {
            return MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }
    }
}
