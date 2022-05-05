using E_agenda_2._0.Entidades;
using Eagenda_2._0.Repositorio;
using System;
using System.Collections.Generic;

namespace E_agenda_2._0.Dominio
{
    public enum StatusPrioridade
    {
        Baixa, Media, Alta
    }

    public class Tarefa : Entidade
    {
        public string Titulo;
        public StatusPrioridade Prioridade;
        public string Descricao;
        public List<Item> Itens;
        public double StatusConclusao;
        public DateTime DataCriacao;
        public DateTime DataConclusao;

        public Tarefa(int id, string titulo, StatusPrioridade prioridade, string descricao, List<Item> itens) : base(id)
        {
            
            Titulo = titulo;
            Prioridade = prioridade;
            Descricao = descricao;
            Itens = itens;
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Titulo}" +
                $"\n{Descricao}" +
                $"\n{DataCriacao}" +
                $"\nPrioridade {Prioridade}";
        }
    }
}
