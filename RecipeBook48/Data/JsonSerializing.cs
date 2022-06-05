using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using MetroFramework.Components;
using MetroFramework;


namespace RecipeBook48
{
    internal static class JsonSerializing
    {
        public static void SqlSettingsToFile(SqlConnection connection)
        {
            try
            {
                string json = JsonSerializer.Serialize(connection);
                File.WriteAllText(@"sqlconfig.json", json);
            }
            catch
            {
                MetroMessageBox.Show(null, "Wystąpił problem z plikiem konfiguracyjnym SQL, przepisy mogą być niedostępne. Sprawdź ustawienia by skonfigurować połączenie na nowo.");
            }

        }

        public static void ReadSqlSettings(ref SqlConnection connection)
        {
            try
            {
                string settings = File.ReadAllText(@"sqlconfig.json");
                connection = JsonSerializer.Deserialize<SqlConnection>(settings);
            }
            catch
            {
                MetroMessageBox.Show(null, "Wystąpił problem z plikiem konfiguracyjnym, nie udało się zapisać zmian.");
            }
        }

        public static void ThemeSettingsToFile(int theme, int color)
        {
            try
            {
                string writeToFile = theme.ToString() + " " + color.ToString();
                File.WriteAllText(@"themeconfig.json", writeToFile);
            }
            catch
            {
                MetroMessageBox.Show(null, "Wystąpił problem z plikiem konfiguracyjnym motywów, przepisy mogą być niedostępne. Sprawdź ustawienia by skonfigurować połączenie na nowo.");
            }
        }
        public static void ReadThemeSettings(ref MetroStyleManager manager)
        {
            try
            {
                string settings = File.ReadAllText(@"themeconfig.json");
                string[] seperated = settings.Split(' ');
                manager.Theme = (MetroThemeStyle)int.Parse(seperated[0]);
                manager.Style = (MetroColorStyle)int.Parse(seperated[1]);
            }
            catch
            {
                MetroMessageBox.Show(null, "Wystąpił problem z plikiem konfiguracyjnym, nie udało się zapisać zmian.");
            }
        }
    }
}
