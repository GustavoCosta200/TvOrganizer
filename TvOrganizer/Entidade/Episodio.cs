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
        public string Titulo { get; set; }
        public string Duração { get; set; }
        public string Descrição { get; set; }
        public string Temporada { get; set; }
        public string Num { get; set; }

        public Episodio() { }
        public Episodio(string titulo, string duração, string descrição, string temporada, string num)
        {
            Titulo = titulo;
            Duração = duração;
            Descrição = descrição;
            Temporada = temporada;
            Num = num;
        }

        public string RetornarInformações()
        {
            return Titulo + " - " + Temporada + "/" + Num + " - " + Duração + "\n" + Descrição;
        }

        public string ConferirEpisodio()
        {
            return Temporada + "/" + Num;
        }
    }
}
