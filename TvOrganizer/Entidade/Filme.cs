using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Filme : Programa
    {
        public int Duração { get; set; }

        public Filme() { }

        public Filme(string nome, string sinopse, string dataLancamento, int id, int[] gênero) : base(nome, sinopse, dataLancamento, id, gênero)
        {
        }

        public Filme(string nome, string sinopse, string datLancamento, string nota, string imagem, int[] genero, int duracao, string tipo, string id) : base(nome, sinopse, datLancamento, nota, imagem, genero)
        {
            Duração = duracao;
        }

        public override bool Equals(object? obj)
        {
            return obj is Filme filme &&
                   Nome == filme.Nome &&
                   Sinopse == filme.Sinopse &&
                   DataLancamento == filme.DataLancamento &&
                   EqualityComparer<int[]>.Default.Equals(Gênero, filme.Gênero) &&
                   Id == filme.Id &&
                   Duração == filme.Duração;
        }
    }
}
