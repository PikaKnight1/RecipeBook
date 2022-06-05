using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;

namespace RecipeBook48
{
    internal class JsonSerializing
    {
        public static void SqlSettingsToFile(SqlConnection connection)
        {
            string json = JsonSerializer.Serialize(connection);
            File.WriteAllText(@"config.json", json);

        }

        public static void ReadSqlSettings(ref SqlConnection connection)
        {
            string settings = File.ReadAllText(@"config.json");
            connection = JsonSerializer.Deserialize<SqlConnection>(settings);
        }
    }
}
