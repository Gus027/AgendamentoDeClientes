using Cabelo_Software.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabelo_Software
{
    public partial class FormInfClie : Form
    {

        public void setNomeCliente(string nome) { name_cli.Text = nome; }
        public string getNomeCliente() { return name_cli.Text; }

        public void setNomeTipo(string nome) { name_type.Text = nome; }
        public string getNomeTipo() { return name_type.Text; }

        public void setNomeDate(string nome) { name_data.Text = nome; }
        public string getNomeDate() { return name_data.Text; }

        public void setNomeHora(string nome) { nome_hora.Text = nome; }
        public string getNomeHora() { return nome_hora.Text; }


        Database dt = new Database();
        NpgsqlCommand cmd;
        NpgsqlConnection conn = null;
        DataTable dataT = new DataTable();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        NpgsqlDataReader reader;

        public FormInfClie()
        {
            InitializeComponent();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var stcx = dt.getConnectionString();
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("DELETE FROM agenda WHERE nm_cliente = @nm_cliente");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        da.SelectCommand = cmd;
                        cmd.Parameters.AddWithValue("@nm_cliente", Verify.NomeCliente);

                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Verify.NomeCliente = Convert.ToString(reader["nm_cliente"]);
                                Verify.NomeDate = Convert.ToString(reader["dt_agenda"]);
                                Verify.NomeType = Convert.ToString(reader["tipo "]);
                            }
                            setNomeCliente(Verify.NomeCliente);
                            setNomeDate(Verify.NomeDate);
                            setNomeTipo(Verify.NomeType);
                        }
                        MessageBox.Show("Agendamento excluido com sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail in Connection");
                conn.Close();
                return;
            }
        }
    }
}
