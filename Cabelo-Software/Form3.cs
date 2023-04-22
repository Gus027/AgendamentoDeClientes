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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CabeloImageButton_Click(object sender, EventArgs e)
        {
            // Ao clicar neste ícone, ele terá que deixar o tipo do corte como (CABELO) 
            // Ja que o mesmo foi selecionado o tipo do corte
            this.Hide();
            Form cl = new FormCabelo();
            cl.Closed += (s, args) => this.Close();
            cl.ShowDialog();

        }

        private void barbaImageButton1_Click(object sender, EventArgs e)
        {
            // Ao clicar neste icone, ele terá que deixar o tipo do corte como (BARBA) 
            // Ja que o mesmo foi selecionado o tipo do corte
            this.Hide();
            Form cl = new FormBarba();
            cl.Closed += (s, args) => this.Close();
            cl.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
