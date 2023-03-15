using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TVOrganizer.Entidade.Enums;

namespace TVOrganizer.Entidade
{
    internal class Programar
    {
        public Programa Programa { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public double Nota { get; set; }
        public string Comentario { get; set; }
        public Status Estado { get; set; }
        public bool Favorito{ get; set; }

        public List<string> IdEpConcluidos { get; private set; }

        public Programar(Programa programa)
        {
            Programa = programa;
            Favorito = false;

            if (programa is Série)
            {
                IdEpConcluidos = new List<string>();
            }
        }

        public void ConcluirPrograma()
        {
            Estado = Status.Concluido;
        }

        public void ConcluirEpisodio(Episodio episodio)
        {
            if (Programa is Série)
            {
                Série? serie = Programa as Série;
                Episodio? ep = serie.Episodios.Find(x => x.Titulo == episodio.Titulo);
                IdEpConcluidos.Add(ep.ConferirEpisodio());
            }
            else
            {
                //Alterar a exceção
                throw new Exception();
            }
        } 
    }
}
