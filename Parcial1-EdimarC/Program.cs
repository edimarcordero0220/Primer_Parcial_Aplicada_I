using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Parcial1_EdimarC.UI;

namespace Parcial1_EdimarC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistroEmpleados());
        }
    }
}
