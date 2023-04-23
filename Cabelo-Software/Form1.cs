using Cabelo_Software.Model;
using Npgsql;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Cabelo_Software
{
    public partial class Form1 : Form
    {
        private Size formSize;
        public Form1()
        {
            InitializeComponent();
        }

        public void setNomeFunc(string nome) { name_func.Text = nome; }
        public string getNomeFunc() { return name_func.Text; }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void buttonTrocar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

            //Overridden methods
    protected override void WndProc(ref Message m)
    {
        const int WM_NCCALCSIZE = 0x0083;
        const int WM_SYSCOMMAND = 0x0112; 
        const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        const int SC_RESTORE = 0xF120; //Restore form (Before)
        const int WM_NCHITTEST = 0x0084;
        const int resizeAreaSize = 10;

        #region Form Resize
        // Resize/WM_NCHITTEST values
        const int HTCLIENT = 1; //Represents the client area of the window
        const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

        ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

        if (m.Msg == WM_NCHITTEST)
        { //If the windows m is WM_NCHITTEST
            base.WndProc(ref m);
            if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
            {
                if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                {
                    Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                    Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                    if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                    {
                        if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                            m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                            m.Result = (IntPtr)HTTOP; //Resize vertically up
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTTOPRIGHT;
                    }
                    else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                            m.Result = (IntPtr)HTLEFT;
                        else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                            m.Result = (IntPtr)HTRIGHT;
                    }
                    else
                    {
                        if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                            m.Result = (IntPtr)HTBOTTOM;
                        else //Resize diagonally to the right
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                    }
                }
            }
            return;
        }
        #endregion

        //Remove border and keep snap window
        if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        {
            return;
        }

        
        if (m.Msg == WM_SYSCOMMAND)
        {
            /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
           
            int wParam = (m.WParam.ToInt32() & 0xFFF0);               

            if (wParam == SC_MINIMIZE)  //Before
               formSize = this.ClientSize;
            if (wParam == SC_RESTORE)// Restored form(Before)
                this.Size = formSize;
        }
        base.WndProc(ref m);
    }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelOrdemClie_Paint(object sender, PaintEventArgs e)
        {
            Database dt = new Database();
            NpgsqlCommand cmd;
            NpgsqlConnection conn = null;
            DataTable dataT = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            NpgsqlDataReader reader;

            var stcx = dt.getConnectionString();

            try
            {
                using (conn = new NpgsqlConnection(stcx))
                {
                    conn.Open();
                    string query = ("SELECT nm_cliente FROM agenda WHERE nm_funcionario = @nm_funcionario");
                    using (cmd = new NpgsqlCommand(query, conn))
                    {
                        da.SelectCommand = cmd;
                        cmd.Parameters.AddWithValue("@nm_funcionario", Verify.NomeUsuario);
                        reader = cmd.ExecuteReader();

                        List<string> nomes = new List<string>();
                        while (reader.Read())
                        {
                            string nome = reader.GetString(0);
                            nomes.Add(nome);
                        }
                        reader.Close();
                        conn.Close();
                       
                        cli_ord1.Text = nomes[0];
                        cli_ord2.Text = nomes[1];
                        cli_ord3.Text = nomes[2];
                        cli_ord4.Text = nomes[3];
                        cli_ord5.Text = nomes[4];
                        cli_ord6.Text = nomes[5];

                    }
                }

            }catch(Exception ex) { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormAgendaConsulta ac = new FormAgendaConsulta();
            ac.ShowDialog();
        }
    }
}