using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.APIControl;
using TVOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Celebridade
    {
        internal static Celebridade ProcurarCelebridade(dynamic celebridade) {

            string name = celebridade.name;
            string dataNascimento = celebridade.birthday;
            string localNascimento = celebridade.place_of_birth;
            int id = celebridade.id;
            string função = celebridade.known_for_department;

            return new Celebridade(name, id, dataNascimento, função, localNascimento);
        }
    }
}
