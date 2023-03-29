using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.Entidade;
using TvOrganizer.Exception;
using TvOrganizer.Serializadores;

namespace TVOrganizer.Controle
{
    internal class C_Login
    {
        public static Usuário usuário { get; private set; }

        public static bool ConferirUsuário(string username, string senha)
        {
            try
            {
                List<Usuário> listaUsuarios = UserSerialization.DesserializarUsuários();
                if (listaUsuarios == null ) 
                {
                    return false;
                }
                foreach (Usuário user in listaUsuarios)
                {
                    if (user.Nome == username && user.Senha == senha)
                    {
                        usuário = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(UserNotFoundException)
            {
            }
            
            return false;
        }

        public static void SalvarAlterações()
        {
            List<Usuário> ListaUsuários = UserSerialization.DesserializarUsuários();

            foreach (Usuário user in ListaUsuários)
            {
                if (user.Nome == usuário.Nome)
                {
                    ListaUsuários.Remove(user);
                    ListaUsuários.Add(usuário);
                    UserSerialization.SerializarUsuario(ListaUsuários);
                    return;
                }
            }
        }
        
    }
}
