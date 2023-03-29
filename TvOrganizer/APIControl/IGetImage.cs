using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.APIControl
{
    internal class IGetImage
    {
        [Get("{poster_path}")]
        Task<string> GetAdressAsync(string posterPath);
    }
}
