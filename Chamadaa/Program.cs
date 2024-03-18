using Chamadaa.View.ViewCadastros;
using Chamadaa.View.ViewDC;
using Chamadaa.View.viewChamada;
using Chamadaa.View.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chamadaa.View.ViewMail;
using Chamadaa.View.ViewLogin;
using Chamadaa.View.ViewEventos;
using Chamadaa.View.View_Eventos;

namespace Chamadaa
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TE_Principal());
        }
    }
}
