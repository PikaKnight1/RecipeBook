using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Components;

namespace RecipeBook48
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MetroStyleManager manager = new MetroStyleManager();
            JsonSerializing.ReadThemeSettings(ref manager);

            FormWelcome formWelcome = new FormWelcome(manager);

            Application.Run(formWelcome);
        }
    }
}
