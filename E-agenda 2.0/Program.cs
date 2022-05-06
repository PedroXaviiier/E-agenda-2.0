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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var telaPrincipal = new TelaPrincipal();
            Application.ApplicationExit += telaPrincipal.SalvarDados;
            Application.Run(telaPrincipal);
        }
    }
}
