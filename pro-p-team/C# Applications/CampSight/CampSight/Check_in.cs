using System;
using BearWithMeLibs;
using Phidgets;
using Phidgets.Events;
using System.Windows.Forms;
using GUI;
using System.Drawing;


namespace CampSight
{
    public partial class Check_in : Form
    {
        private Image[] imageSuccess;
        private Image[] imageDelined;
        //checkin-
        private RFID rfid;
        private ConnectToPhpMyAdmin connection;
        private bool mode = true;
        private bool logedIn = false;
        private short counter = 0;
        private string[] campingLocations;
        public Check_in()
        {
            InitializeComponent();
            CheckIn_pb1.Visible = false;
            CheckIn_pb1.Enabled = false;
            notSigned_in_PB1.Visible = false;
            notSigned_in_PB1.Enabled = false;
            connection = new ConnectToPhpMyAdmin();
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
            panel_signIn.Visible = false;
            panel_signIn.Enabled = false;
            combo_Box_Number.Visible = false;
            combo_Box_Number.Enabled = false;
            Location_PB.Enabled = false;
            Location_PB.Visible = false;
            Lb_Location.Visible = false;
            lb_Number.Visible = false;
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 94, ".png");
            imageDelined = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");
            campingLocations = new string[] { "BBQ", "Beach", "HUD", "CampFire" };
            for (int i = 0; i < campingLocations.Length; i++)
            {
                combo_box_Location.Items.Add(campingLocations[i]);
            }
            for (int i = 0; i < 7; i++)
            {
                combo_Box_Number.Items.Add(i);
            }

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            rfid.LED = false;
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
            int visitorID = 0;
            panel_signIn.Visible = false;
            panel_signIn.Enabled = false;
            connection.conToDB();
            visitorID = connection.GetIntFromDB("Visitor_idVisitor", "camping", "Visitor_idVisitor = " + connection.GetVisitorIDFromDB("idVisitor", e.Tag.ToString()).ToString());
            if (mode)
            {

                if (visitorID == connection.GetVisitorIDFromDB("idVisitor", e.Tag.ToString()))
                {
                    timer1.Interval = 2;
                    timer1.Enabled = true;
                    CheckIn_pb1.Enabled = true;
                    CheckIn_pb1.Visible = true;
                    logedIn = true;
                    return;
                }
                timer1.Interval = 2;
                timer1.Enabled = true;
                notSigned_in_PB1.Enabled = true;
                notSigned_in_PB1.Visible = true;
                logedIn = false;
            }
            else
            {
                try
                {
                    visitorID = connection.GetVisitorIDFromDB("idVisitor", e.Tag.ToString());
                    int reserv = connection.GetInt32FromDB("Reservation_idReservation", "camping");
                    if (connection.CheckIfExistsInDB(e.Tag.ToString(), "RFID", "visitor"))
                    {
                        int depositLine = connection.GetIntFromDB("idDepositLine", "depositLine", "Visitor_idVisitor = " + connection.GetVisitorIDFromDB("idVisitor", e.Tag.ToString()).ToString());
                        connection.SendQuery("INSERT INTO reservation(HasEnteredEvent, DepositLine_idDepositLine, DepositLine_PayPal_idPayPal) VALUES ("+ 1 +"," + depositLine +"," + 123456789 + ");");
                        if (connection.RFIDCheck(e.Tag.ToString(), "INSERT INTO camping(CampingLocation, NrOfGuests, Total, Reservation_idReservation, Visitor_idVisitor) VALUES (" + "'" + combo_box_Location.SelectedItem.ToString() + "'" + "," + combo_Box_Number.SelectedIndex + "," + ((combo_Box_Number.SelectedIndex * 20) + 30) + "," + reserv + "," + "'" + visitorID + "'" + ");"))
                        {
                            timer1.Interval = 2;
                            timer1.Enabled = true;
                            CheckIn_pb1.Enabled = true;
                            CheckIn_pb1.Visible = true;
                            logedIn = true;
                            return;
                        }
                        timer1.Interval = 2;
                        timer1.Enabled = true;
                        logedIn = false;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                timer1.Interval = 2;
                timer1.Enabled = true;
                notSigned_in_PB1.Enabled = true;
                notSigned_in_PB1.Visible = true;
                logedIn = false;
            }
        }
        public void rfid_TagLost(object sender, TagEventArgs e)
        {
            connection.DisConFromDB();
        }
        private void btn_Sign_In(object sender, EventArgs e)
        {
            panel_signIn.Visible = true;
            panel_signIn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (logedIn)
                    if (counter > imageSuccess.Length - 1)
                    {
                        CheckIn_pb1.Enabled = false;
                        CheckIn_pb1.Visible = false;
                        combo_Box_Number.Enabled = false;
                        combo_Box_Number.Visible = false;
                        lb_Number.Visible = false;
                        Location_PB.Visible = false;
                        Location_PB.Enabled = false;
                        Lb_Location.Visible = false;
                        combo_box_Location.ResetText();
                        combo_Box_Number.ResetText();
                        mode = true;

                        timer1.Enabled = false;
                        counter = 0;
                    }
                    else
                    {
                        CheckIn_pb1.Image = imageSuccess[counter];
                        counter++;
                    }
                else
                if (counter > imageDelined.Length + 40)
                {
                    notSigned_in_PB1.Enabled = false;
                    notSigned_in_PB1.Visible = false;
                    combo_Box_Number.Enabled = false;
                    combo_Box_Number.Visible = false;
                    lb_Number.Visible = false;
                    Location_PB.Visible = false;
                    Location_PB.Enabled = false;
                    Lb_Location.Visible = false;
                    combo_box_Location.ResetText();
                    combo_Box_Number.ResetText();
                    mode = true;
                    timer1.Enabled = false;
                    counter = 0;
                }
                else
                {
                    notSigned_in_PB1.Image = imageDelined[counter];
                    counter++;
                }
            }
            catch (Exception) { counter++; }
        }
        private void combo_box_Location_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Box_Number.Enabled = true;
            combo_Box_Number.Visible = true;
            lb_Number.Visible = true;
        }

        private void combo_Box_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            Location_PB.Enabled = true;
            Location_PB.Visible = true;
            Lb_Location.Visible = true;
            mode = false;
        }
    }
}
