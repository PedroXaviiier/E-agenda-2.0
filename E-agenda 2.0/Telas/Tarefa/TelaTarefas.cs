using E_agenda_2._0.Dominio;
using Eagenda_2._0.Repositorio;
using System;
using System.Windows.Forms;

namespace E_agenda_2._0.Telas
{
    public partial class TelaTarefas : Form
    {
        public RepositorioBase<Tarefa> RepositorioTarefas;
        public TelaTarefas()
        {
            InitializeComponent();
            RepositorioTarefas = new RepositorioBase<Tarefa>();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
