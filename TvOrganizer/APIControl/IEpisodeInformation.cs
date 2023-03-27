using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace TvOrganizer.APIControl
{
    internal interface IEpisodeInformation
    {
        [Get("/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}?api_key=243e6209b25ea186082a268d75c966bd&language=pt-BR")]
        Task<string> GetAdressAsync(string tv_id, string season_number, string episode_number);
    }
}
