using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.Entidade
{
    internal class Usuário
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public string Email { get; private set; }

        public Usuário(string nome, string senha, string email)
        {   
            Nome = nome;
            Senha = senha;
            Email = email;
            DataCriacao = DateTime.Now;
        }

        public bool VerificarCadastro(string senhaColocada)
        {
            if (Senha == senhaColocada) { return true; } else { return false; }
        }

        public bool ProcurarUsuario(string user)
        {
            if (Nome == user) { return true; } else { return false; }
        }
    }
}
