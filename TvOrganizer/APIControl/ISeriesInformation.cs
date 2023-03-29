using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.APIControl
{
    internal interface ISeriesInformation
    {
        [Get("/3/tv/{tv_id}?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR")]
        Task<string> GetAdressAsync(string tv_id);
    }
}
