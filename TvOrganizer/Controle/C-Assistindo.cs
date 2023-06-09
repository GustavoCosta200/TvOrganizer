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

            IEnumerable<Programar> programadosEnum = programas.Where(x => x.Estado == Entidade.Enums.Status.Assistindo);

            List<Programar> programados = programadosEnum.ToList();

            return programados;

        }
        internal static void ProgramarAssistir(Programar programar)
        {
            programar.ProgramaAssistir();
            C_Login.SalvarAlterações();
        }

        internal static void ProgramarAssistir(dynamic results, string tipo)
        {
            int id = results.id;

            Programar programar = C_Programa.CriarProgramar(results, tipo);
            //Procura um programar entre os dados do usuário que tenha o mesmo id e tipo
            //Se houver seleciona esse programar e muda-se seu estado apenas, senão cria um novo programar;
            Programar resultadoProgramar = C_Programa.ProcurarProgramar(programar);
            if (resultadoProgramar != null)
            {
                resultadoProgramar.ProgramaAssistir();
                C_Login.SalvarAlterações();
            }
            else
            {
                programar.ProgramaAssistir();
                C_Login.usuário.programasSalvos.Add(programar);
                C_Login.SalvarAlterações();
            }

        }

        internal static string RetornarProximoEpisodio(Programar programar)
        {
            return programar.VerificarEpisodiosConcluidos();
        }

    }
}
