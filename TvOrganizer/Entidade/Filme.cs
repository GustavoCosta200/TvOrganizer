using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Filme : Programa
    {
        public string Duração{ get; set; }
        public string Tipo { get; set;}

        public Filme() { }

        public Filme(string nome, string sinopse, DateTime datLancamento, string nota, string imagem, string genero, string duracao, string tipo) : base(nome, sinopse, datLancamento, nota, imagem, genero)
        {
            Duração = duracao;
            Tipo = tipo;
        }

    }
}
