using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvOrganizer.APIControl;
using TVOrganizer.Controle;
using TVOrganizer.Entidade;

namespace TVOrganizer.Fronteira
{
    public partial class frmCelebridade : Form
    {
        public frmCelebridade()
        {
            InitializeComponent();
        }

        private void nudPágina_ValueChanged(object sender, EventArgs e)
        {
            CarregarCelebridades();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            nudPágina.Value = 1;
            dgvCelebridadesSearch.Rows.Clear();
            CarregarCelebridades();
        }

        private async void CarregarCelebridades()
        {
            //Pedido à API para celebridade
            var celebrity = RestService.For<ISearchPerson>("https://api.themoviedb.org");
            var celebrityList = await celebrity.GetAdressAsync(txtPesquisa.Text.Trim(), nudPágina.Value.ToString());
            dynamic celebrities = JsonConvert.DeserializeObject(celebrityList);

            int pageMax = celebrities.total_pages;

            nudPágina.Maximum = pageMax;

            PreencherCampos(celebrities);
        }

        private async void PreencherCampos(dynamic celebridades)
        {
            dynamic resultados = celebridades.results;

            foreach (dynamic resultado in resultados)
            {
                int id = resultado.id;
                //Informações de Celebridade
                var celebrity = RestService.For<ICelebrityInformation>("https://api.themoviedb.org");
                var celebrityList = await celebrity.GetAdressAsync(id.ToString());
                dynamic celebridade = JsonConvert.DeserializeObject(celebrityList);

                Celebridade celeb = C_Celebridade.ProcurarCelebridade(celebridade);

                //Informações dos programas da celebridade
                var moviesRequest = RestService.For<IGetCelebrityMoviees>("https://api.themoviedb.org");
                var movieList = await moviesRequest.GetAdressAsync(id.ToString());
                dynamic movies = JsonConvert.DeserializeObject(movieList);

                string nomesProgramas = "";
                dynamic cast = movies.cast;
                foreach (dynamic program in cast)
                {
                    string name = "";
                    try
                    {
                        name = program.title;
                    }
                    catch (Exception ex)
                    {
                        name = program.name;
                    }

                    if (!String.IsNullOrEmpty(name)) 
                    {
                        nomesProgramas += name + " | " + Environment.NewLine;
                    }
                }

                string[] linha = { celeb.Nome, celeb.Função, celeb.DataNascimento, celeb.LocalNascimento, nomesProgramas };
                dgvCelebridadesSearch.Rows.Add(linha);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaProgramas frmTelaProgramas = new frmTelaProgramas();
            frmTelaProgramas.Show();
            this.Hide();
        }

        private void dgvCelebridadesSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
