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
using System.Windows.Markup;

namespace Cabelo_Software
{
    public partial class FormAgendaConsulta : Form
    {
        public FormAgendaConsulta()
        {
            InitializeComponent();
        }

        Database dt = new Database();
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        DataTable dataT;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgendaConsulta_Load(object sender, EventArgs e)
        {
            Select();
        }
        public void Select()
        {

            var stcx = dt.getConnectionString();
            try
            {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string querySelect = @"SELECT * FROM agenda WHERE nm_funcionario = @nm_funcionario ORDER BY nm_cliente;";
                    cmd = new NpgsqlCommand(querySelect, conn);
                    cmd.Parameters.AddWithValue("@nm_funcionario", Verify.NomeUsuario);
                    dataT = new DataTable();
                    dataT.Load(cmd.ExecuteReader());
                    conn.Close();
                    dgvData.DataSource = null; //Reset dataGrid
                    dgvData.DataSource = dataT;

                }

            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show("Error na Select!");
            }
        }
    }
}
