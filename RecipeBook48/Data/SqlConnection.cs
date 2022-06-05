using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace RecipeBook48
{
    public class SqlConnection
    {
        [JsonInclude]
        public string Host { get; set; }
        [JsonInclude]
        public string Port { get; set; }
        [JsonInclude]
        public string User { get; set; }
        [JsonInclude]
        public string Password { get; set; }
        [JsonInclude]
        public string Sid { get; set; }

        public SqlConnection()
        {
        }

        public SqlConnection(string host, string port, string user, string password, string sid)
        {
            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Password = password;
            this.Sid = sid;
        }

        public bool TestSqlConnection()
        {
            string sql = $"data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = {this.Host})(PORT = {this.Port})))(CONNECT_DATA =(SERVICE_NAME = {this.Sid})));USER ID={this.User};PASSWORD={this.Password}";
            OracleConnection connection = new OracleConnection(sql);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
