using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvOrganizer.Entidade;
using TvOrganizer.Exception;

namespace TvOrganizer.Serializadores
{
    internal sealed class UserSerialization
    {
        private static string Caminho = @"C:\Users\Alien\source\repos\TvOrganizer\TvOrganizer\DadosUsuários\dadosUsuarios.json";
        //Adiciona Usuário na lista de objetos serializados
        public static void SerializarUsuario(Usuário usuario)
        {
            List<Usuário> usuarios;
            try
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Caminho))
                    {
                        string jsonString = sr.ReadToEnd();
                        usuarios = JsonConvert.DeserializeObject<List<Usuário>>(jsonString);
                        if (usuarios == null || usuarios.Count == 0)
                        {
                            usuarios = new List<Usuário> { };
                            usuarios.Add(usuario);
                        }
                        else
                        {
                            usuarios.Add(usuario);
                        }
                    }
                }
                catch (NullReferenceException error)
                {
                    usuarios = new List<Usuário> { };
                    usuarios.Add(usuario);
                }
                using (StreamWriter sw = new StreamWriter(Caminho))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(sw, usuarios);
                }
            }
            catch(IOException)
            {  
            }
        }
        //Serializa uma lista de usuários
        public static void SerializarUsuario(List<Usuário> usuarios)
        {
            try
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(Caminho))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        jsonSerializer.Serialize(sw, usuarios);
                    }
                }
                catch (NullReferenceException error)
                {
                }
            }
            catch (IOException)
            {
            }
        }
        //Retorna usuários desserializados
        public static List<Usuário> DesserializarUsuários()
        {
            List<Usuário> usuarios;
            try
            {
                using (StreamReader sr = new StreamReader(Caminho))
                {
                    string jsonString = sr.ReadToEnd();
                    usuarios = JsonConvert.DeserializeObject<List<Usuário>>(jsonString);
                }
            }
            catch(IOException)
            {
                usuarios = null;
            }
            return usuarios;
        }

    }
}
