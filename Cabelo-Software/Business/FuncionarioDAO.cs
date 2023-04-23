using Cabelo_Software.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cabelo_Software.Business
{
    internal class FuncionarioDAO
    {
        Database dt = new Database();
        NpgsqlCommand cmd;
        NpgsqlConnection conn;


        public FuncionarioDAO() { }



        public async void InsertFunc(Funcionario c)
        {
            
            var stcx = dt.getConnectionString();


            try
            {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("Insert Into funcionario(name,userr,password) values(@name,@userr,@password)");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", c.getName());
                        cmd.Parameters.AddWithValue("@userr", c.getUserr());
                        cmd.Parameters.AddWithValue("@password", c.getUserPassword());
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Funcionario Cadastrado Com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha na conexão Insert");
            }
        }

    }
}
