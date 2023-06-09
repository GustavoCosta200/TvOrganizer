using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Celebridade
    {
        public string? Nome { get; set; }
        public int? Id { get; set; }
        public string? DataNascimento { get; set; }
        public string? Função { get; set; }
        public string? LocalNascimento { get; set; }
        public List<Programa>? Programas { get; set; }

        public Celebridade()
        {
        }

        public Celebridade(string nome, int id)
        {
            Nome = nome;
            Id = id;
            Programas = new List<Programa>();
        }

        public Celebridade(string nome, int id, string? dataNascimento, string? função, string? localNascimento) : this(nome, id)
        {
            try
            {
                DateTime data = DateTime.ParseExact(dataNascimento, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DataNascimento =  data.ToString("dd-MM-yyyy");
            }
            catch (ArgumentNullException)
            {
                DataNascimento = "-";
            }
            catch (FormatException)
            {
                DataNascimento = "-";
            }
            Programas = new List<Programa>();
            Função = função;
            LocalNascimento = localNascimento;  
        }

    }

} 
