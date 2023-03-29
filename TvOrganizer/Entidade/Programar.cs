using Newtonsoft.Json;
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
        [JsonProperty("Programa")]
        public Programa Programa { get; set; }
        [JsonProperty("Data")]
        public DateTime? Data { get; set; }
        [JsonProperty("Hora")]
        public DateTime? Hora { get; set; }
        [JsonProperty("Nota")]
        public double? Nota { get; set; }
        [JsonProperty("Comentario")]
        public string? Comentario { get; set; }
        [JsonProperty("Estado")]
        public Status? Estado { get; set; }
        [JsonProperty("Favorito")]
        public bool? Favorito { get; set; }
        [JsonProperty("IdEpConcluidos")]
        public List<Episodio>? IdEpConcluidos { get; private set; }

        public Programar() { }

        public Programar(Programa programa)
        {
            Programa = programa;
            Favorito = false;
            if (programa is Série)
            {
                Série serie = programa as Série;
                IdEpConcluidos = new List<Episodio>(serie.Episodios);
            }

        }

        public Programar(Programa programa, Status? estado) : this(programa)
        {
            Estado = estado;
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
                try
                {
                    IdEpConcluidos.Add(ep);
                }
                catch (ArgumentNullException e)
                {
                }

                //Organiza os episódios da lista de concluídos


            }
            else
            {
                //Alterar a exceção
                throw new Exception();
            }
        }

        public void ProgramarAssistir(Episodio episodio)
        {
            Estado = Status.Assistindo;
        }

        public string VerificarEpisodiosConcluidos()
        {
            if (Programa is not Série)
            {
                throw new Exception();
            }
            else
            {
                return "1";
            }
        }
    }
}
