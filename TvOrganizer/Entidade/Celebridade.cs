using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVOrganizer.Entidade
{
    internal class Celebridade
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Funcao { get; set; }
        public string Foto { get; set; }
        public int Id { get; set; }
        public List<Programa> Programas { get; set; }

        public Celebridade(string nome, string idade, string funcao, string foto, int id, params Programa[] programas)
        {
            Nome = nome;
            Idade = idade;
            Funcao = funcao;
            Foto = foto;
            Id = id;
            Programas = new List<Programa>();

            for (int i = 0; i < programas.Length; i++)
            {
                Programas.Add(programas[i]);
            }
        }

        public string VerCelebridade()
        {
            return Nome + " - " + Idade + " - " + Funcao;
        }
    }
}
