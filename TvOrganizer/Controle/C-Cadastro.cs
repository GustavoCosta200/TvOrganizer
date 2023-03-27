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
    internal class C_Cadastro
    {
        public static void CriarCadastro(string nome, string senha, string email)
        {
            Usuário user = new Usuário(nome, senha, email);
            if (!IsValidEmail(email)) { throw new InvalidEmailException("E-Mail Inválido"); }
            try
            {
                ProcurarUsuario(user);
                throw new UserAlreadyExists("Usuário já existe");
            }
            catch (UserNotFoundException e)
            {
                try
                {
                    UserSerialization.SerializarUsuario(user);
                }
                catch (NullReferenceException error)
                {

                }
            }
            catch (NullReferenceException e)
            {
                UserSerialization.SerializarUsuario(user);
            }
        }

        public static void ProcurarUsuario(Usuário user)
        {
            List<Usuário> usuariosCadastrados = UserSerialization.DesserializarUsuários();
            if (usuariosCadastrados == null)
            {
                throw new UserNotFoundException("Usuário não existe");
            }
            if (!(usuariosCadastrados.Contains(user)))
            {
                throw new UserNotFoundException("Usuário não existe");
            }

        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
