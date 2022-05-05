

namespace E_agenda_2._0.Entidades
{
    public class Item
    {
        public string Descricao;
        public bool Concluido;

        public Item(string descricao)
        {
            Descricao = descricao;
            Concluido = false;
        }

        string statusConclusao = "";


        public override string ToString()
        {

            if (Concluido == true)
            {
                statusConclusao = "concluído";
            }

            else if (Concluido == false)
            {
                statusConclusao = "pendente";
            }


            return $"{Descricao}, status: {statusConclusao}";
        }

    }
}
