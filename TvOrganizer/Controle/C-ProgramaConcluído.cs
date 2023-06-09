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
            programar.ConcluirPrograma();
            C_Login.SalvarAlterações();
        }

        internal static void ConcluirPrograma(dynamic results, string tipo)
        {
            int id = results.id;
            Programar programar = C_Programa.CriarProgramar(results, tipo);
            //Procura um programar entre os dados do usuário que tenha o mesmo id e tipo
            //Se houver seleciona esse programar e muda-se seu estado apenas, senão cria um novo programar;
            Programar resultadoProgramar = C_Programa.ProcurarProgramar(programar);
            if (!(resultadoProgramar == null))
            {
                resultadoProgramar.ConcluirPrograma();
                C_Login.SalvarAlterações();
            }
            else
            { 
                programar.ConcluirPrograma();
                C_Login.usuário.programasSalvos.Add(programar);
                C_Login.SalvarAlterações();
            }
        }

        internal static void AvaliarPrograma(Programar programa, string avaliação, decimal nota)
        {
            programa.AdicionarComentário(avaliação);
            programa.AdicionarNota((double) nota);
            C_Login.SalvarAlterações();
        }

    }
}
