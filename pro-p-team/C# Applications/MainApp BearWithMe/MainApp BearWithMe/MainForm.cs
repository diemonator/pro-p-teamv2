using System;
using System.Windows.Forms;
using App_For_PayPal;
using EmployeeLogInProP;
using GUI;
using EntranceAppProP;
using CampSight;
using ISSDappProP;
using History;
using EntranceClientApp;

namespace MainApp_BearWithMe
{
    public partial class MainForm : Form
    {
        Form form;
        public MainForm()
        {
            InitializeComponent();            
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void btn_PayPal_Init_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new PaypalFrom());
            form.Show();
        }

        private void btn_Camping_Init_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new Check_in());
            form.Show();
        }

        private void btn_SD_Init_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new SDapp());
            form.Show();
        }

        private void btn_Food_Init_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new FStandForm());            
            form.Show();
        }
        private void btn_Entrance_Init_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new AdministatorForm());
            form.Show();
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new Form1());
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new LogInFormNew(new ClientForm());
            form.Show();
        }
    }

}
