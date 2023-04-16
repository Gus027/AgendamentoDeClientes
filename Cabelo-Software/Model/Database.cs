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
        static string psw = "123456";
        static string port = "5432";


        string connectionString = String.Format("SERVER={0},DB={1},USER={2},PASSWORD={3},PORT={4}",
                server, 
                db,
                user,
                psw,
                port);
    

        public async void openConn()
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
