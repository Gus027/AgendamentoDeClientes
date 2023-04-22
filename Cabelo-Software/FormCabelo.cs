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
    public partial class FormCabelo : Form
    {
        public FormCabelo()
        {
            InitializeComponent();
        }
        //public string getCalendar() { return this.hairCalendar.ToString(); }

        private void agendarCabelo_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            string txt = "";
            if (americanoBox1.Checked)
            {
                txt += americanoBox1.Text;
                ag.setTipo(txt);
            }
            else if (navalhadoBox5.Checked)
            {
                txt += navalhadoBox5.Text;
                ag.setTipo(txt);
            }
            else if (desfarçadoBox2.Checked)
            {
                txt += desfarçadoBox2.Text;
                ag.setTipo(txt);
            }
            else if (infantilBox3.Checked)
            {
                txt += infantilBox3.Text;
                ag.setTipo(txt);
            }
            else if (platinaldoBox4.Checked)
            {
                txt += platinaldoBox4.Text;
                ag.setTipo(txt);
            }
            else if (outroBox6.Checked)
            {
                txt += outroBox6.Text;
                ag.setTipo(txt);
            }
        }
    }
}
