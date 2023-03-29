using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.APIControl;
using TVOrganizer.Fronteira;
using TVOrganizer.Entidade;
using TvOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Programa
    {
       
        internal static List<Série> RetornarSéries(dynamic results)
        {
            List<Série> respProgramas = new List<Série>();
            foreach (var item in results)
            {
                string title = item.name;
                string overview = item.overview;
                string release_date = item.first_air_date;
                int id = item.id;

                respProgramas.Add(new Série(title, overview, release_date, id));
            }
            return respProgramas;
        }

        internal static List<Filme> RetornarFilmes(dynamic results)
        {
            List<Filme> respProgramas = new List<Filme>();

            foreach (var item in results)
            {
                string title = item.title;
                string overview = item.overview;
                string release_date = item.release_date;
                int id = item.id;

                respProgramas.Add(new Filme(title, overview, release_date, id));
            }
            return respProgramas;
        }

        internal static Programar CriarProgramar(dynamic results, string tipo)
        {
            if (tipo == "Série")
            {
                string nome = results.name;
                string sinopse = results.overview;
                string dataLancamento = results.first_air_date;
                int id = results.id;
                int i = 0;
                var infoGeneros = results.genres;
                List<string> generos = new List<string>();
                foreach (var item in infoGeneros)
                {
                    string name = item.name;
                    generos.Add(name);
                }
                string[] generosNome = generos.ToArray();
                int nepisodios = results.number_of_episodes;
                string finalizada = results.status;
                int ntemporadas = results.number_of_seasons;

                Série serie = new Série(nome, sinopse, dataLancamento, id, generosNome, nepisodios, ntemporadas, finalizada);

                //Gera os episódios que farão parte dessa série
                dynamic temporadas = results.seasons;
                C_Episodio.GerarEpisódios(temporadas, id, serie);

                Programar progamado = new Programar(serie);

                return progamado;
            }
            else
            {
                string nome = results.title;
                string sinopse = results.overview;
                string datLancamento = results.release_date;
                double nota = results.vote_average;
                string imagem = results.poster_path;

                var infoGeneros = results.genres;
                List<string> generos = new List<string>();
                foreach (var item in infoGeneros)
                {
                    string name = item.name;
                    generos.Add(name);
                }
                string[] generosNome = generos.ToArray();
                int duracao = results.runtime;
                int id = results.id;

                Filme filme = new Filme(nome, sinopse, datLancamento, nota, imagem, generosNome, duracao, id);

                Programar progamado = new Programar(filme);
                
                return progamado;
            }
        }

        //Procura os programados do usuário com o id e o tipo
        internal static Programar ProcurarProgramar(int id, string tipo)
        {
            Usuário user = C_Login.usuário;

            Programar programado = user.programasSalvos.FirstOrDefault(x => x.Programa.Id == id && x.Programa.GetType().ToString() == tipo);

            return programado;
        }
    }
}
