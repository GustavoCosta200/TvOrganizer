using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace TvOrganizer.APIControl
{
    internal interface IGetPopular
    {
        [Get("/3/movie/popular?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR&page={page}")]
        Task<string> GetAdressAsync(string page);
    }
}
