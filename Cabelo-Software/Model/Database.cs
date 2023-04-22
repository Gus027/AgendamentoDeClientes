using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabelo_Software.Model
{
    internal class Database
    {
        static string server = "localhost";
        static string db = "hair";
        static string user = "postgres";
        static string password = "123456";
        static string port = "5432";


        string connectionString = String.Format("Host={0};Port={1};Username={2};Password={3};Database={4};",
            server,
            port,
            user,
            password,
            db);

        public string getConnectionString(){ return this.connectionString; }


        public async void OpenConn()
        {
            try
            {
                await using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

            }
            catch (Exception ex)
            {
                //Show("Error na Conexão com banco de dados!");

                MessageBox.Show(ex.Message + "ERROR NA CONEXÃO");
                //conn.Close();
            }
        }
    }
}
