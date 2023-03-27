using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.APIControl
{
    internal interface IMovieInformation
    {
        [Get("/3/movie/{id}?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR")]
        Task<string> GetAdressAsync(string id);
    }
}
