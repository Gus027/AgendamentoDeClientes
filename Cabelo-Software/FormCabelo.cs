using Cabelo_Software.Business;
using Cabelo_Software.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabelo_Software
{
    public partial class FormCabelo : Form
    {
        private string tipo;

        public void setTipo(string tipo) { this.tipo = tipo; }

        public string getTipo() { return this.tipo; }

        public FormCabelo()
        {
            InitializeComponent();
        }
        NpgsqlCommand cmd;
        NpgsqlConnection conn;
        Funcionario f = new Funcionario();

        Database dt = new Database();
        public string getCalendar() { return this.hairCalendar.Value.ToString(); }
        public string getCliNome() { return nm_cliente.Text; }

        private void agendarCabelo_Click(object sender, EventArgs e)
        {
            string txt = "";


            if (americanoBox1.Checked)
            {
                txt += americanoBox1.Text;
                setTipo(txt);
            }
            if (navalhadoBox5.Checked)
            {
                txt += navalhadoBox5.Text;
                setTipo(txt);
            }
            if (desfarçadoBox2.Checked)
            {
                txt += desfarçadoBox2.Text;
                setTipo(txt);
            }
            if (infantilBox3.Checked)
            {
                txt += infantilBox3.Text;
                setTipo(txt);
            }
            if (platinaldoBox4.Checked)
            {
                txt += platinaldoBox4.Text;
                setTipo(txt);
            }
            if (outroBox6.Checked)
            {
                txt += outroBox6.Text;
                setTipo(txt);
            }

            var stcx = dt.getConnectionString();
            try
            {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("INSERT INTO agenda(dt_agenda,hora,nm_cliente,tipo,nm_funcionario) VALUES (@dt_agenda,@hora,@nm_cliente,@tipo,@nm_funcionario)");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dt_agenda", getCalendar());
                        cmd.Parameters.AddWithValue("@hora", hr_ag.Text);
                        cmd.Parameters.AddWithValue("@nm_cliente", getCliNome());
                        cmd.Parameters.AddWithValue("@tipo", getTipo());           // <---  Verificar Lógica de puxar o tipo selecionado
                        cmd.Parameters.AddWithValue("@nm_funcionario", Verify.NomeUsuario); // <---  Puxar da classe Funcionario o mesmo que se encontra logado no sistema.
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Cliente Agendado Com Sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conection Fail for Insert ->" + ex.Message);
            }
 
        }
    }
}
