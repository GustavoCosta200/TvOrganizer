using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.APIControl
{
    internal interface ISearchSeries
    {
        [Get("/3/search/tv?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR&page={page}&query={name}&include_adult=false")]
        Task<string> GetAdressAsync(string name, string page);
    }
}
