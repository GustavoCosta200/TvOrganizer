﻿using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.APIControl;
using TVOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Episodio
    {
        internal async static void GerarEpisódios(dynamic seasons, int seriesId, Série serie)
        {
            foreach (var season in seasons)
            {
                var seasonRequest = RestService.For<ISeasonInformation>("https://api.themoviedb.org");
                var seriesList = await seasonRequest.GetAdressAsync(seriesId.ToString(), season.id.ToString());
                dynamic seasonGet = JsonConvert.DeserializeObject(seriesList);
                //Retorna os episódios da temporada atual
                dynamic episodios = seasonGet.episodes;

                foreach (dynamic episodio in episodios)
                {
                    string titulo = episodio.name;
                    string sinopse = episodio.overview;
                    int nepisodio = episodio.episode_number;
                    int ntemporada = episodio.season_number;

                    Episodio episode = new Episodio(titulo, sinopse, ntemporada, nepisodio);

                    serie.AddEpisódio(episode);
                }
            }


        }
        

        
    }
}
