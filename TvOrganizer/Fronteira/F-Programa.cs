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
using TvOrganizer.APIControl;
using Newtonsoft.Json;
using Refit;
using System.Globalization;

namespace TVOrganizer.Fronteira
{
    public partial class frmPrograma : Form
    {
        private dynamic programa = null;
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
            }
            else if (programa is Filme)
            {
                CarregarDadosFilme(id);
            }
        }

        private async void CarregarDadosFilme(int id)
        {
            //Procura os dados do filme na API com o id
            var movieRequest = RestService.For<IMovieInformation>("https://api.themoviedb.org");
            var movieSeries = await movieRequest.GetAdressAsync(id.ToString());
            dynamic movie = JsonConvert.DeserializeObject(movieSeries);

            programa = movie;

            //Formata os dados dos labels
            lblTítulo = movie.title;
            lblSinopse = movie.overview;
            lblNota = movie.vote_average.toString();
            lblDataLançamento = DateTime.ParseExact(movie.release, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString();
            lblDuração = movie.runtime.ToString();
            lblNumEp.Enabled = false;
            lblStatus.Enabled = false;
            lblNumTemp.Enabled = false;
            foreach(var item in movie.genres)
            {
                ltbGêneros.Items.Add(item.name);
            }
            btnEpisódios.Enabled = false;
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
            frmTelaProgramas frmtela = new frmTelaProgramas();
            frmtela.ShowDialog();
            this.Hide();
        }
    }
}
