using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Calendário
    {
        internal static void AdicionarCalendário(Programar programa, string data, string hora)
        {
            programa.AdicionarHorario(hora);
            programa.AdicionarData(data);
            C_Login.SalvarAlterações();
        }
    }
}
