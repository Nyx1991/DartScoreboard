using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartScoreboard
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ScoreboardForm scoreboardForm = new ScoreboardForm();

            WebServer.SetForm(scoreboardForm);
            WebServer.Start();

            Application.Run(scoreboardForm);
        }
    }
}
