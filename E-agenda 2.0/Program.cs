using E_agenda_2._0.Dominio;
using E_agenda_2._0.Entidades;
using Eagenda_2._0.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_agenda_2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Item> itens = new List<Item>();

            itens.Add(new Item("mamando"));
            Tarefa tarefa1 = new Tarefa(1, "mamar", StatusPrioridade.Alta, "tenho, tenho que mamar", itens);
            var repositorio = new RepositorioBase<Tarefa>();
            repositorio.AdicionarEntidade(tarefa1);
            repositorio.SalvarDados();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var telaPrincipal = new TelaPrincipal();
            Application.ApplicationExit += telaPrincipal.SalvarDados;

            
            Application.Run(telaPrincipal);
        }
    }
}
