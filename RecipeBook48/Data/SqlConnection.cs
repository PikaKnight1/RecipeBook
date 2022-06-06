using Oracle.ManagedDataAccess.Client;

using System.Text.Json.Serialization;

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

        private readonly string sqlConnectionString;

        public SqlConnection(string host, string port, string user, string password, string sid)
        {
            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Password = password;
            this.Sid = sid;

            this.sqlConnectionString = $"data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)" +
                                       $"(HOST = {this.Host})" +
                                       $"(PORT = {this.Port})))" +
                                       $"(CONNECT_DATA =(SERVICE_NAME = {this.Sid})));" +
                                       $"USER ID={this.User};" +
                                       $"PASSWORD={this.Password}";
        }

        public bool TestSqlConnection()
        {
            OracleConnection connection = new OracleConnection(this.sqlConnectionString);

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

        public OracleConnection GetConnection()
        {
            return new OracleConnection(sqlConnectionString);
        }

        public OracleDataReader GetReader(string sqlCommand)
        {
            OracleConnection connect = this.GetConnection();

            connect.Open();
            OracleCommand command = connect.CreateCommand();
            command.CommandText = sqlCommand;
            OracleDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void Execute(string sqlCommand)
        {
            OracleConnection connect = this.GetConnection();
            connect.Open();

            OracleCommand command = connect.CreateCommand();
            command.CommandText = sqlCommand;
            command.ExecuteNonQuery();

            connect.Close();
        }
    }
}
