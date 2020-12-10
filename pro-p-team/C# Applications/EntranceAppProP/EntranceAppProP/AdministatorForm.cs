using System;
using System.Windows.Forms;
using SimpleTCP;
using System.Text;
using BearWithMeLibs;

namespace EntranceAppProP
{
    public partial class AdministatorForm : Form
    {
        //fields        
        private readonly ActivetiesList actveties;
        private readonly ActivetieView activetieView;
        private SimpleTcpServer server;
        private ConnectToPhpMyAdmin connection;
        private const string m_ipAddress = "127.0.0.1";
        private const int port = 5090;
        string response;
        private static short counter = 0;
        //ctor
        public AdministatorForm()
        {
            InitializeComponent();
            activetieView = new ActivetieView(lb_Activeties);
            actveties = new ActivetiesList();
            actveties.ActivetieAdded += activetieView.AddToActiveties;
            actveties.ActivetieRemoved += activetieView.RemoveFromActiveties;
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += SERVET_RECIEVER;
            cb_Stand.Items.Add("Food stand");
            cb_Stand.Items.Add("SD stand");
            connection = new ConnectToPhpMyAdmin();
            label7.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            cb_Stand.Visible = false;
            cb_Stand.Enabled = false;
            btn_Send.Visible = false;
            btn_Send.Enabled = false;
            timer1.Interval = 1000;
        }

        private void lb_Activeties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Activeties.SelectedIndex >= 0)
            {
                tb_Activeties.Text = Convert.ToString(lb_Activeties.Items[lb_Activeties.SelectedIndex]);
            }
            else
            {
                tb_Activeties.Clear();
            }
        }

        private void SERVET_RECIEVER(object sender, SimpleTCP.Message m)
        {

            char[] temp = m.MessageString.ToString().ToCharArray();
            string message = "";
            for (int i = 0; i < temp.Length - 1; i++)
            {
                message += temp[i].ToString();
            }
            if (message == "request" || message == "request" + "")
            {
                foreach (Activeties item in actveties.GetList())
                {
                    m.ReplyLine(item.ToString());
                }
            }
            else
            {
                lb_Activeties.Invoke((MethodInvoker)delegate
                {
                    lb_Notify.Items.Add(message);
                });

            }

        }

        private void btn_CrActive_Click(object sender, EventArgs e)
        {
            try
            {
                response = actveties.AddActivetie(tb_Activeties.Text, tb_location.Text, Convert.ToDecimal(tb_Price.Text));
                tb_location.Clear();
                tb_Activeties.Clear();
                tb_Price.Clear();
                server.BroadcastLine(tb_Activeties.Text.ToString());

            }
            catch (Exception ex)
            {
                lb_status.Text = ex.ToString();
            }
        }

        private void btn_RemActive_Click(object sender, EventArgs e)
        {
            int index = lb_Activeties.SelectedIndex;
            if (index >= 0)
            {
                actveties.RemoveActivetie(tb_Activeties.Text, tb_location.Text);
                tb_location.Clear();
                tb_Activeties.Clear();

            }
            else
            {
                timer1.Enabled = true;
                lb_status.Text = "Please select a activity that needs to be removed";
            }
        }

        private void btn_sendReminder_Click(object sender, EventArgs e)
        {
            connection.conToDB();
            if (connection.SendQuery("INSERT INTO employee(EmployeeName, Stand_idStand) VALUES(" + "'" + textBox1.Text + "'" + "," + (cb_Stand.SelectedIndex + 1) + ");") == " ")
            {
                label7.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox1.Enabled = false;
                cb_Stand.Visible = false;
                cb_Stand.Enabled = false;
                btn_Send.Visible = false;
                btn_Send.Enabled = false;
                timer1.Enabled = true;
                lb_status.Text = "Added Successfully";
            }
            connection.DisConFromDB();

        }
        //methods
        protected override void WndProc(ref System.Windows.Forms.Message m)
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Activate_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip;
            ip = System.Net.IPAddress.Parse(m_ipAddress);
            server.Start(ip, port);
            btn_Activate.Enabled = false;
            lb_status.Text = "Server has started";
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
            this.Close();
        }

        private void btn_Emp_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            cb_Stand.Visible = true;
            cb_Stand.Enabled = true;
            btn_Send.Visible = true;
            btn_Send.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter >= 5)
            {
                lb_status.Text = "Administration app";
                timer1.Enabled = false;
                counter = 0;
            }
            counter++;
        }
    }
}
