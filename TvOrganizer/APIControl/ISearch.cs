using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.APIControl
{
    internal interface ISearch
    {
        [Get("/3/search/multi?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR&query={name}&page=1&include_adult=false")]
        Task<string> GetAdressAsync(string name);
    }
}
