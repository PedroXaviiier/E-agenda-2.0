using Eagenda_2._0.Repositorio;

namespace E_agenda_2._0.Dominio
{
    public class Contato : Entidade
    {
        
        public string Nome;
        public string Telefone;
        public string Email;
        public string Empresa;
        public string Cargo;

        public Contato(int id, string nome, string telefone, string email, string empresa, string cargo) : base(id)
        {
            
            
            ID = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Empresa = empresa;
            Cargo = cargo;
        }

        

        public override string ToString()
        {
            return $"{Nome}" +
                $"\n{Telefone}" +
                $"\n{Email}" +
                $"\n{Cargo} da {Empresa}";
        }
    }
}
