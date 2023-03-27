using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.Entidade;
using TVOrganizer.Entidade;

namespace TvOrganizer.Entidade
{
    internal class Usuário
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public string Email { get; private set; }
        public List<Programar> programasSalvos { get; private set; }
        public Usuário(string nome, string senha, string email)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            DataCriacao = DateTime.Now;
            programasSalvos = new List<Programar>();
        }

        public bool VerificarCadastro(string senhaColocada)
        {
            if (Senha == senhaColocada) { return true; } else { return false; }
        }

        public bool ProcurarUsuario(string user)
        {
            if (Nome == user) { return true; } else { return false; }
        }
        public override bool Equals(object other)
        {
            if (!(other is Usuário))
            {
                return false;
            }
            Usuário obj = other as Usuário;
            return Nome.Equals(obj.Nome);
        }
    }
}
