﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Filme : Programa
    {
        [JsonProperty("Duração")]
        public int Duração { get; set; }

        public Filme() { }

        public Filme(string nome, string sinopse, string dataLancamento, int id) : base(nome, sinopse, dataLancamento, id)
        {
        }

        public Filme(string nome, string sinopse, string datLancamento, double nota, string imagem, string[] genero, int duracao, int id) : base(nome, sinopse, datLancamento, nota, imagem, genero, id)
        {
            Duração = duracao;
        }

        public override bool Equals(object? obj)
        {
            return obj is Filme filme &&
                   Nome == filme.Nome &&
                   Sinopse == filme.Sinopse &&
                   DataLancamento == filme.DataLancamento &&
                   EqualityComparer<string[]>.Default.Equals(Gênero, filme.Gênero) &&
                   Id == filme.Id &&
                   Duração == filme.Duração;
        }
    }
}
