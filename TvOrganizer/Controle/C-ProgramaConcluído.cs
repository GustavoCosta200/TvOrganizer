using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVOrganizer.Entidade;
using TvOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_ProgramaConcluído
    {
        internal static List<Programar> RetornarConcluídos()
        {

            Usuário user = C_Login.usuário;

            List<Programar> programas = user.programasSalvos;

            IEnumerable<Programar> programadosEnum = programas.Where(x => x.Estado == Entidade.Enums.Status.Concluido);

            List<Programar> concluídos = programadosEnum.ToList();

            return concluídos;
        }

        internal static void ConcluirPrograma(Programar programar)
        {
            programar.Estado = Entidade.Enums.Status.Concluido;
            C_Login.SalvarAlterações();
        }

        internal static void ConcluirPrograma(dynamic results, string tipo)
        {
            int id = results.id;

            Programar? programar = C_Programa.ProcurarProgramar(id, tipo);
            //Procura um programar entre os dados do usuário que tenha o mesmo id e tipo
            //Se houver muda o seu estado apenas, senão cria um novo programar;
            if (programar == null)
            {
                programar = C_Programa.CriarProgramar(results, tipo);
            }

            programar.Estado = Entidade.Enums.Status.Concluido;
            C_Login.usuário.programasSalvos.Add(programar);
            C_Login.SalvarAlterações();
        }
    }
}
