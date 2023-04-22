using Cabelo_Software.Business;
using Cabelo_Software.Model;
using Microsoft.EntityFrameworkCore.Update;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Database dt = new Database();
            NpgsqlCommand cmd;
            NpgsqlConnection conn=null;
            DataTable dataT = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            NpgsqlDataReader reader;

            var stcx = dt.getConnectionString();


            if (pass_text.Text == "")
            {
                MessageBox.Show("Preencha o campo senha");
                user_text.Focus();
                return;
            }

            if (user_text.Text == "") {
                MessageBox.Show("Preencha o campo Usuario");
                user_text.Focus();
                return;
            }


            if (user_text.Text == "" && pass_text.Text == "") {
                MessageBox.Show("Insira Usuario e Senha.");
                user_text.Focus();
                pass_text.Focus();
                return;
            }


            try {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("SELECT * FROM funcionario WHERE userr = @userr AND password = @password");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        da.SelectCommand = cmd;
                        cmd.Parameters.AddWithValue("@userr", user_text.Text);
                        cmd.Parameters.AddWithValue("@password", pass_text.Text);
                        reader = cmd.ExecuteReader();
                        if(reader.HasRows)
                        {
                            while (reader.Read()) 
                            {
                                Verify.NomeUsuario = Convert.ToString(reader["name"]);
                            }
                            MessageBox.Show("Bem-Vindo Novamente "+Verify.NomeUsuario);
                            Form1 f1 = new Form1();
                            f1.ShowDialog();
                            this.Close();
                            return;
                        }
                        MessageBox.Show("Erro a Logar!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ->"+ ex.Message);
            }

        }
    }
}
