using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Programa
    {
        [JsonProperty("Nome")]
        public string? Nome { get; set; }
        [JsonProperty("Sinopse")]
        public string? Sinopse { get; set; }
        [JsonProperty("DataLancamento")]
        public string? DataLancamento { get; set; }
        [JsonProperty("Nota")]
        public double? Nota { get; set; }
        [JsonProperty("Imagem")]
        public string? Imagem { get; set; }
        [JsonProperty("Gênero")]
        public string[]? Gênero { get; set; }
        [JsonProperty("Id")]
        public int Id { get; set; }

        public Programa() { }

        public Programa(string? nome, int id)
        {
            Nome = nome;
            Id = id;
        }

        protected Programa(string? nome, string? sinopse, string? dataLancamento, double? nota)
        {
            Nome = nome;
            Sinopse = sinopse;
            DataLancamento = dataLancamento;
            Nota = nota;
        }

        public Programa(string? nome, string? sinopse, string? dataLancamento, double? nota, string? imagem, string[]? gênero, int id)
        {
            Nome = nome;
            Sinopse = sinopse;
            DataLancamento = Convert(dataLancamento);
            Nota = nota;
            Imagem = imagem;
            Gênero = gênero;
            Id = id;
        }

        public Programa(string nome, string sinopse, string dataLancamento, int id, string[] gênero)
        {
            Nome = nome;
            Sinopse = sinopse;
            Id = id;
            Gênero = gênero;
            DataLancamento = Convert(dataLancamento);
        }

        public Programa(string nome, string sinopse, string dataLancamento, int id)
        {
            Nome = nome;
            Sinopse = sinopse;
            DataLancamento = Convert(dataLancamento);
            Id = id;

        }

        private string Convert(string data) 
        {
            try
            {
                DateTime dataLancamento = DateTime.ParseExact(data, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                return dataLancamento.ToString("dd-MM-yyyy");
            }
            catch (ArgumentNullException)
            {
                return "-";
            }
            catch (FormatException)
            {
                return "-";
            }
        }
    }
}
