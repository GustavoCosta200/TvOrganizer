using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.Entidade;
using TVOrganizer.Entidade;

namespace TVOrganizer.Controle
{
    internal class C_Favoritos
    {
        internal static List<Programar> RetornarFavoritos()
        {
            Usuário user = C_Login.usuário;

            List<Programar> programas = user.programasSalvos;

            IEnumerable<Programar> favortiosEnum = programas.Where(x => x.Favorito == true);

            List<Programar> favoritos = favortiosEnum.ToList();

            return favoritos;
        }

        internal static void FavoritarPrograma(Programar programar)
        {
            programar.FavoritarPrograma();
            C_Login.SalvarAlterações();
        }

        internal static void DesfavoritarPrograma(Programar programar)
        {
            programar.DesfavoritarPrograma();
            C_Login.SalvarAlterações();
        }
    }
}
