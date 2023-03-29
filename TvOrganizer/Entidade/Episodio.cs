using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Episodio
    {
        [JsonProperty("Titulo")]
        public string? Titulo { get; set; }
        [JsonProperty("Descrição")]
        public string? Descrição { get; set; }
        [JsonProperty("Temporada")]
        public int? Temporada { get; set; }
        [JsonProperty("Num")]
        public int? Num { get; set; }
        [JsonProperty("Id")]
        public string Id { get; set; }

        public Episodio() { }
        public Episodio(string titulo, string descrição, int temporada, int num)
        {
            Titulo = titulo;
            Descrição = descrição;
            Temporada = temporada;
            Num = num;
            Id = temporada.ToString() + "/" + num.ToString();
        }

        public string RetornarInformações()
        {
            return Titulo + " - " + Temporada + "/" + Num + " - "  + "\n" + Descrição;
        }

        public string ConferirEpisodio()
        {
            return Temporada + "/" + Num;
        }
    }
}
