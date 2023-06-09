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
        public string Data { get; set; }
        [JsonProperty("Hora")]
        public string Hora { get; set; }
        [JsonProperty("Nota")]
        public double? Nota { get; set; }
        [JsonProperty("Comentario")]
        public string? Comentario { get; set; }
        [JsonProperty("Estado")]
        public Status Estado { get; set; }
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
                IdEpConcluidos = new List<Episodio>();
            }
        }

        public Programar(Programa programa, Status estado) : this(programa)
        {
            Estado = estado;
        }

        public void ConcluirPrograma()
        {
            Estado = Status.Concluido;
        }
        public void ProgramaAssistir()
        {
            Estado = Status.Assistindo;
        }

        public void FavoritarPrograma()
        {
            Favorito = true;
        }

        public void DesfavoritarPrograma()
        {
            Favorito = false;
        }

        public void ConcluirEpisodio(Episodio episodio)
        {
            if (IdEpConcluidos is null)
            {
                return;
            }

            for (int i = 0; i < IdEpConcluidos.Count; i++)
            {
                if (IdEpConcluidos[i] == null) { continue;  }

                if (IdEpConcluidos[i].Equals(episodio))
                {
                    IdEpConcluidos[i] = null;
                    return;
                }


            }
        }

        public string? VerificarEpisodiosConcluidos()
        {
            if (IdEpConcluidos == null)
            {
                return null;
            }
            else
            {
                try
                {
                    for (int i = IdEpConcluidos.Count - 1; i >= 0; i--)
                    {
                        try
                        {

                            // Se o último episódio está concluido então a série foi concluida
                            if (IdEpConcluidos[i] == null && i == IdEpConcluidos.Count - 1)
                            {
                                Estado = Status.Concluido;
                                return null;

                            }
                            //O próximo episódio será o após o último episódio concluído (removido)
                            else if (IdEpConcluidos[i] == null)
                            {
                                return IdEpConcluidos[i + 1].Id;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                        }
                    }
                    return IdEpConcluidos[0].Id;
                }
                catch (Exception ex) { return null; }
            }


        }

        public void AdicionarComentário(string comentário)
        {
            Comentario = comentário;
        }

        public void AdicionarNota(double nota)
        {
            Nota = nota;
        }

        public void AdicionarData(string data)
        {
            Data = data;
        }

        public void AdicionarHorario(string hora)
        {
            Hora = hora;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Programar))
            {
                return false;
            }
            Programar other = obj as Programar;

            return Programa.Id.Equals(other.Programa.Id);
        }
    }
}
