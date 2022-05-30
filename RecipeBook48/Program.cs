using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //wczytanie ustawień

            //połączenie z bazą danych

            //doopiero wtedy start
            MetroFramework.Components.MetroStyleManager manager = new MetroFramework.Components.MetroStyleManager();
            manager.Theme = MetroFramework.MetroThemeStyle.Dark;
            manager.Style = MetroFramework.MetroColorStyle.Lime;

            FormWelcome fw = new FormWelcome(manager);

            Application.Run(fw);
        }
    }
}
