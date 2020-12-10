using System;
using BearWithMeLibs;
using System.Windows.Forms;
using GUI;
using System.Drawing;


namespace EmployeeLogInProP
{
    public partial class LogInFormNew : Form
    {
        //images 
        private Image[] imageSuccess;
        private Image[] imageDenied;
        private Form loginForm; 
        //connection         
        private ConnectToPhpMyAdmin connection;
        //Timer 
        private Timer timer;
        private int frame = 0;
        private bool loggedIn = false;
        public LogInFormNew(Form log)
        {
            InitializeComponent();
            connection = new ConnectToPhpMyAdmin();
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 93, ".png");
            imageDenied = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");
            loginForm = log;
            timer = new Timer();
            timer.Interval = 2;
            timer.Tick += new EventHandler(TIMER_TICK);
        }
        public LogInFormNew()
        {
            InitializeComponent();
            connection = new ConnectToPhpMyAdmin();
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 93, ".png");
            imageDenied = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");            
            timer = new Timer();
            timer.Interval = 2;
            timer.Tick += new EventHandler(TIMER_TICK);
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

        private void lbLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pb_LogIn_Click(object sender, EventArgs e)
        {
            connection.conToDB();
            if (connection.ParameterCheck(tb_EmpId.Text, tb_EmployeeName.Text, "idEmployee", "EmployeeName", "employee"))
            {
                loggedIn = true;
                timer.Enabled = true;
            }
            else
            {
                loggedIn = false;
                timer.Enabled = true;
            }
            connection.DisConFromDB();
        }
        private void TIMER_TICK(object sender, EventArgs e)
        {
            try
            {
                if (loggedIn)
                {
                    if (frame <= imageSuccess.Length - 1)
                    {
                        pb_Animation.Image = imageSuccess[frame];
                        frame++;
                    }
                    else
                    {
                        loginForm.Show();
                        frame = 0;
                        pb_Animation.Image = imageSuccess[3];
                        timer.Enabled = false;
                        this.Close();
                    }
                }
                else
                {
                    if (frame <= imageDenied.Length - 1)
                    {
                        pb_Animation.Image = imageDenied[frame];
                        frame++;
                    }
                    else
                    {
                        frame = 0;                        
                        timer.Enabled = false;
                    }
                }

            }
            catch (Exception)
            {
                frame = 0;
            }
        }
    }
}
