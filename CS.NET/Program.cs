using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Program
{
    static class Program
    {

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Softgroup.FrmStandard());
        }
    }
}
