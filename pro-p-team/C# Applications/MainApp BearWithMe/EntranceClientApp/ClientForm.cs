using System;
using BearWithMeLibs;
using Phidgets;
using Phidgets.Events;
using System.Windows.Forms;
using GUI;
using System.Drawing;
using EntranceAppProP;
using SimpleTCP;
using System.Text;

namespace EntranceClientApp
{
    public partial class ClientForm : Form
    {
        public ActivetieView activeView { get; }
        private readonly Client client;
        private ConnectToPhpMyAdmin connection;
        private RFID rfid;
        private ResizeTimer timer;
        private Image[] imageSuccess;
        private Image[] imageDenied;
        private const string m_ipAddress = "127.0.0.1";
        private const int port = 5090;
        private SimpleTcpClient gishka;

        //checkin-
        public ClientForm()
        {
            InitializeComponent();
            pb_anim.Visible = false;
            activeView = new ActivetieView(lb_GichkaForm);
            client = new Client(tb_FirstName.Text, tb_lastName.Text, tb_BankInfo.Text, tb_Address.Text);            
            connection = new ConnectToPhpMyAdmin();

            timer = new ResizeTimer();
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 93, ".png");
            imageDenied = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");
            gishka = new SimpleTcpClient();
            gishka.StringEncoder = Encoding.UTF8;
            gishka.DataReceived += CLIENT_RECIEVER;
         

            initRFID();
        }
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
        private void CLIENT_RECIEVER(object sender, SimpleTCP.Message m)
        {
            lb_GichkaForm.Invoke((MethodInvoker)delegate ()
                {
                    lb_GichkaForm.Items.Clear();
                    char[] temp = m.MessageString.ToString().ToCharArray();
                    string message = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == '')
                        {

                            lb_GichkaForm.Items.Add(message);
                            message = "";
                            timer1.Enabled = false;
                            continue;
                        }
                        message += temp[i].ToString();
                    }
                });

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            rfid.close();
            rfid = null;
            this.Close();
        }
        public void rfid_attach(object sender, AttachEventArgs e)
        {

        }
        public void rfid_detach(object sender, DetachEventArgs e)
        {

        }
        public void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
        public void rfid_Tag(object sender, TagEventArgs e)
        {
            try
            {
                pb_anim.Visible = true;
                connection.conToDB();

                if (!connection.CheckIfExistsInDB(e.Tag.ToString(), "RFID", "visitor"))
                {
                    if (connection.SendQuery("INSERT INTO visitor(RFID,Name,Address,HasEntered,IsWebUser) VALUES(" + "'" + e.Tag.ToString() + "'" + "," + "'" + tb_FirstName.Text + " " + tb_lastName.Text + "'" + "," + "'" + tb_Address.Text + "'" + "," + 1 + "," + 0 + ");") == " ")
                    {
                        int visitorID = connection.GetInt32FromDB("idVisitor", "visitor");
                        connection.SendQuery("INSERT INTO eventvisitor(Visitor_idVisitor,Telefon,EventAccount) VALUES (" + visitorID + "," + "'" + tb_telephone.Text + "'" + "," + (Convert.ToDouble(tb_EventAccount.Text) - 25) + ");");
                        gishka.WriteLine(tb_FirstName.Text + " " + tb_lastName.Text + " : " + lb_GichkaForm.Items[lb_GichkaForm.SelectedIndex]);
                        tb_Address.Clear();
                        tb_BankInfo.Clear();
                        tb_EventAccount.Clear();
                        tb_FirstName.Clear();
                        tb_lastName.Clear();
                        tb_telephone.Clear();
                        timer.StartTimerSuccessAnim(pb_anim, imageSuccess);
                    }
                }
                timer.StartTimerSuccessAnim(pb_anim, imageDenied);
            }
            catch (Exception ex)
            {
                tb_status.Text = ex.ToString();
            }
        }
        public void rfid_TagLost(object sender, TagEventArgs e)
        {
            tb_status.Text = "";
            connection.DisConFromDB();
        }
        private void initRFID()
        {
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_attach);
            rfid.Detach += new DetachEventHandler(rfid_detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open();
            rfid.waitForAttachment();
            rfid.Antenna = true;
            rfid.LED = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gishka.WriteLineAndGetReply("request", TimeSpan.FromSeconds(1));
            tb_status.Text = "";
        }
        private void btn_RegisterClient_Click(object sender, EventArgs e)
        {
            try
            {             
                Client c = new Client(tb_FirstName.Text, tb_lastName.Text, tb_BankInfo.Text, tb_Address.Text);                                       
                tb_status.Text = "Check your RFID ";                                   
            }
            catch (Exception)
            {

                tb_status.Text = "Please enter the correct details on the fields";
            }

        }
        private void UpdateRegisterButton()
        {
            Activeties a = GetSelectedActivetie();
            if (a != null)
            {
                bool subscribed = client.IsRegistered(a);
                btn_AddTo_Reg.Enabled = !subscribed;
              
            }
            else
            {
                btn_AddTo_Reg.Enabled = false;              
            }
        }


        private Activeties GetSelectedActivetie()
        {
            if (lb_GichkaForm.SelectedIndex >= 0)
            {
                return (Activeties)lb_GichkaForm.Items[lb_GichkaForm.SelectedIndex];
            }
            else
            {
                return null;
            }
        }        
        private void lb_GichkaForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRegisterButton();
        }

        private void btn_Remove_Reg_Click(object sender, EventArgs e)
        {
            Activeties a = GetSelectedActivetie();
            if (a != null)
            {
                client.RemoveClient(a);
                UpdateRegisterButton();
            }
            else
            {
                MessageBox.Show("Pleace select a Activetie");
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1.Interval = 5000;
                gishka.Connect(m_ipAddress, port);
                gishka.WriteLineAndGetReply("request", TimeSpan.FromSeconds(1));
                tb_status.Text = "Client entrance app";
                btn_connect.Text = "Update";
            }
            catch (Exception)
            {

                tb_status.Text = "Server is Having problems";
            }
        }
    }
}
