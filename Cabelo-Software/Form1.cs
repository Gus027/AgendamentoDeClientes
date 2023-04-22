using System.Threading;

namespace Cabelo_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonTrocar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void buttonAgendar_Click_1(object sender, EventArgs e)
        {
            Form fm = new Form3();
            fm.ShowDialog();
        }

        private void btn_func_Click(object sender, EventArgs e)
        {
            FormCadastroFunc f = new FormCadastroFunc();
            f.ShowDialog();
        }
    }
}