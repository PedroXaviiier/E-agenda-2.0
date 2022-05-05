using E_agenda_2._0.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda_2._0
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            TelaTarefas = new TelaTarefas();
        }

        public TelaTarefas TelaTarefas { get; }

        internal void SalvarDados(object? sender, EventArgs e)
        {
            TelaTarefas.RepositorioTarefas.SalvarDados();
        }
    }
}
