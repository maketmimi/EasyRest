using EasyRest.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmMain MainForm = new FrmMain();

            if (args.Count() == 1 && args[0].ToLower() == "-silent")
                Application.Run();
            else
                Application.Run(MainForm);
        }
    }
}
