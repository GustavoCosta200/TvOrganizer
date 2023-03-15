using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Série: Programa
    {
        public int Nepisodios { get; set; }
        public bool Finalizada { get; set; }
        public List<Episodio> Episodios { get; set; }

        public Série(int nepisodios, bool finalizada, params Episodio[] episodios)
        {
            Nepisodios = nepisodios;
            Finalizada = finalizada;
            Episodios = new List<Episodio>();
            //Adiciona os Episódios na lista de Episódios
            for (int i = 0; i < episodios.Length; i++)
            {
                Episodios.Add(episodios[i]);
            }
        }
    }
}
