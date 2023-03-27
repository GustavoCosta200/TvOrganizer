using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal abstract class Programa
    {
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Nota { get; set; }
        public string Imagem { get; set; }
        public List<string> Gênero { get; set; }
        public List<Celebridade> Celebridades { get; set; }

        public Programa() { }

        public Programa(string nome, string sinopse, DateTime datLancamento, string nota, string imagem, string genero, params Celebridade[] celebridades)
        {
            Nome = nome;
            Sinopse = sinopse;
            DataLancamento = datLancamento;
            Nota = nota;
            Imagem = imagem;
            Gênero = new List<string>();
            Gênero.Add(genero);
            Celebridades = new List<Celebridade>();

            for (int i = 0; i < celebridades.Length; i++)
            {
                Celebridades.Add(celebridades[i]);
            }
        }

        public bool VerificarInformações(string nome)
        {
            if (nome == Nome) { return true; } else { return false; }
        }
    }
}
