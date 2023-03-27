using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.Entidade;
using TvOrganizer.Serializadores;
using TVOrganizer.Controle;
using TVOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Assistindo
    {
        public static List<Programar>? retornarProgramados()
        {

            Usuário user = C_Login.usuário;
            List<Programar> programas = user.programasSalvos;

            IEnumerable<Programar> programados = programas.Where(x => x.Estado.Equals(Entidade.Enums.Status.Assistindo) || x.Estado.Equals(Entidade.Enums.Status.Programado));

            return programados as List<Programar>;

        }

    }
}
