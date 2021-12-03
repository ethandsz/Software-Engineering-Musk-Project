using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteInspection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Records start of a new session on the logbook
            //logbook._Instance.wrt("");
            logbook._Instance.wrt(DateTime.Now.ToString("h:mm:ss tt"));
            logbook._Instance.wrt("Program Started");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

        }
    }
}
