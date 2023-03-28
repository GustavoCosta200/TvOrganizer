using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal abstract class Programa
    {
        public string? Nome { get; set; }
        public string? Sinopse { get; set; }
        public string? DataLancamento { get; set; }
        public string? Nota { get; set; }
        public string? Imagem { get; set; }
        public int[]? Gênero { get; set; }
        public int? Id { get; set; }
        public List<Celebridade>? Celebridades { get; set; }

        public Programa() { }

        public Programa(string nome, string sinopse, string dataLancamento, int id, int[] gênero)
        {
            Nome = nome;
            Sinopse = sinopse;
            Id = id;
            Gênero = gênero;
            try
            {
                DateTime data = DateTime.ParseExact(dataLancamento, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DataLancamento = data.ToString("dd-MM-yyyy");
            } catch (ArgumentNullException)
            {
                DataLancamento = "01-01-1970";
            } catch(FormatException)
            {
                DataLancamento = "01-01-1970";
            }
        }

        public Programa(string nome, string sinopse, string datLancamento, string nota, string imagem, int[] genero, params Celebridade[] celebridades)
        {
            Nome = nome;
            Sinopse = sinopse;
            DateTime data = DateTime.ParseExact(datLancamento, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DataLancamento = data.ToString("dd-MM-yyyy");
            Nota = nota;
            Imagem = imagem;
            Gênero = genero;
            Celebridades = new List<Celebridade>();

            for (int i = 0; i < celebridades.Length; i++)
            {
                Celebridades.Add(celebridades[i]);
            }
        }

        protected Programa(string nome, string sinopse, string dataLancamento, int id)
        {
            Nome = nome;
            Sinopse = sinopse;
            DataLancamento = dataLancamento;
            Id = id;
        }
    }
}
