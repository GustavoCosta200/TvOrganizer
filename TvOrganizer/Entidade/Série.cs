using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Série : Programa
    {
        public int? Nepisodios { get; set; }
        public bool? Finalizada { get; set; }
        public List<Episodio>? Episodios { get; set; }

        public Série(string nome, string sinopse, string dataLancamento, int id) :
            base(nome, sinopse, dataLancamento, id)
        {
        }

        public Série(string nome, string sinopse, string dataLancamento, int id, int[] gênero, int nepisodios, bool finalizada, params Episodio[] episodios) : 
            base (nome, sinopse, dataLancamento, id, gênero)
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
