using E_agenda_2._0.Dominio;
using Eagenda_2._0.Repositorio;

namespace E_agenda_2._0.Entidades
{
    public class Compromisso : Entidade
    {
        
        public string Assunto;
        public Contato Contato;
        public string Local;
        public int Data;
        public int HoraInicio;
        public int HoraTermino;

        public Compromisso(int id, string assunto, Contato contato, string local, int data, int horaInicio, int horaTermino) : base(id)
        {
            
            Assunto = assunto;
            Contato = contato;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;

        }

        public override string ToString()
        {
            return $"{Local}" +
                $"\n{Data}-{HoraInicio} às {HoraTermino}";
        }
    }
}
