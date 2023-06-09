using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Série : Programa
    {
        [JsonProperty("Nepisodios")]
        public int? Nepisodios { get; set; }
        [JsonProperty("NTemporadas")]
        public int? NTemporadas { get; set; }
        [JsonProperty("Status")]
        public string Status { get; set; }
        public List<Episodio>? Episodios { get; set; }

        public Série() { }

        public Série(string nome, string sinopse, string dataLancamento, int id) :
            base(nome, sinopse, dataLancamento, id)
        {
        }


        public Série(string nome, string sinopse, string dataLancamento, int id, string[] gênero, int nepisodios, int ntemporadas, string finalizada) : 
            base (nome, sinopse, dataLancamento, id, gênero)
        {
            Nepisodios = nepisodios;
            Status = finalizada;
            NTemporadas = ntemporadas;
        }

        internal void AddEpisódio(List<Episodio> episodios)
        {
            Episodios = episodios;
        }
    }
}
