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
    internal class Agenda
    {
        public Agenda() { }

        //   private string dt_agenda;
        private string nm_cliente;
        private string tipo;

        public void setNm_cliente(string nm_cliente) { this.nm_cliente = nm_cliente; }
        public string getNm_cliente() { return this.nm_cliente; }

        public void setTipo(string tipo) { this.tipo = tipo; }
        public string getTipo() { return this.tipo; }




        Database dt = new Database();
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        Funcionario f = new Funcionario();
        FormCabelo fc = new FormCabelo();
        Agenda c = new Agenda();
        public void InsertAgendaCabelo()
        {
            var stcx = dt.getConnectionString();
            try
            {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("INSERT INTO agenda(dt_agenda,hora,nm_cliente,tipo,nm_funcionario) VALUES (@dt_agenda,@hora,@nm_cliente,@tipo,@nm_funcionario)");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dt_agenda", fc.getCalendar());
                    //    cmd.Parameters.AddWithValue("@hora", fc.getHora());
                        cmd.Parameters.AddWithValue("@nm_cliente", fc.getCliNome());
                        cmd.Parameters.AddWithValue("@tipo", c.getTipo());           // <---  Verificar Lógica de puxar o tipo selecionado
                        cmd.Parameters.AddWithValue("@nm_funcionario", Verify.NomeUsuario); // <---  Puxar da classe Funcionario o mesmo que se encontra logado no sistema.
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Cliente Agendado Com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Conection Fail for Insert ->" +e.Message);
            }
        }
    }
}
