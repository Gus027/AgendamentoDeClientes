using Cabelo_Software.Business;
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
    public partial class FormCadastroFunc : Form
    {
        public FormCadastroFunc()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            FuncionarioDAO fdao = new FuncionarioDAO();
            Funcionario f = new Funcionario();
            f.setName(nm_func.Text);
            f.setUserr(user_func.Text);
            f.setPassword(pssw_func.Text);

            fdao.InsertFunc(f);
            this.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
