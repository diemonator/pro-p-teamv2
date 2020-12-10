using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Phidgets.Events;
using Phidgets;
using BearWithMeLibs;

namespace GUI
{
    public partial class CustomerList : Form
    {
        //fields                
        private RFID rfid;
        private ConnectToPhpMyAdmin c;
        private double sum = 0;
        private Order order;
        private Image[] imageSuccess;
        private Image[] imageDenied;
        private Timer timer;
        private int frame = 0;
        private bool loggedIn = false;
        public delegate void ResetHandler();
        public event ResetHandler reset;
        //ctor
        public CustomerList(Order clientOrder)
        {
            InitializeComponent();
            c = new ConnectToPhpMyAdmin();
            order = clientOrder;
            AssignListBox();
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 93, ".png");
            imageDenied = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");
            TimerInit();
        }
        private void TimerInit()
        {
            timer = new Timer();
            timer.Interval = 2;
            timer.Tick += new EventHandler(TIMER_TICK);
            pb_Animation.Visible = false;
            pb_Animation.Enabled = false;
        }
        private void AssignListBox()
        {
            foreach (IProduct item in order.products)
                lb_RemoveList.Items.Add(item.ToString());
        }
        private void SetUpRFID()
        {
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open();
            rfid.waitForAttachment();
            rfid.Antenna = true;
            rfid.LED = true;
        }
        //methods
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
            try
            {
                rfid.LED = false;
                rfid.close();
                rfid = null;
            }
            catch (Exception)
            {
                this.Close();
            }
            this.Close();
        }
        /// <summary>
        /// Populates the from with initial picture boxes
        /// </summary>
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (lb_RemoveList.Items.Count <= 0)
            {
                MessageBox.Show("You have nothing in your cart");
                return;
            }
            lb_RemoveList.Items.Clear();
            SetUpRFID();
            pb_rfid.Visible = true;
            pb_rfid.Enabled = true;
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lb_RemoveList.SelectedIndex;
                lb_RemoveList.Items.RemoveAt(index);
                order.products.RemoveAt(index);
            }
            catch (Exception) { }
        }

        //attach event handler...display the serial number of the attached RFID phidget
        private void rfid_Attach(object sender, AttachEventArgs e)
        {

        }
        //detach event handler...display the serial number of the detached RFID phidget
        private void rfid_Detach(object sender, DetachEventArgs e)
        {

        }
        //Error event handler...display the error description string
        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
        }
        //Print the tag code of the scanned tag
        private void rfid_Tag(object sender, TagEventArgs e)
        {
            int[] qArray = order.Quantity().ToArray();
            int n = 0;
            c.conToDB();
            try
            {
                /*try
                {
                    for (int i = 0; i < gallery.ListOfProductDrinks.Count; i++)
                        for (int x = 0; x < gallery.ListOfDecoratorDrinks[i].Length; x++)
                            c.SendQuery("INSERT INTO food(Description,UnitPrice) VALUES (" + "'" + gallery.ListOfDecoratorDrinks[i][x].ToString() + "'" + "," + gallery.ListOfDecoratorDrinks[i][x].Cost() + ");");
                    for (int i = 0; i < gallery.ListOfProductFood.Count; i++)
                        for (int x = 0; x < gallery.ListOfDecoratorFoods[i].Length; x++)
                            c.SendQuery("INSERT INTO food(Description,UnitPrice) VALUES (" + "'" + gallery.ListOfDecoratorFoods[i][x].ToString() + "'" + "," + gallery.ListOfDecoratorFoods[i][x].Cost() + ");");

                    c.DisConFromDB();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }*/
                double total = 0;
                Int32 foodID = c.GetInt32FromDB("FoodOrder_idFoodOrder", "orderline") + 1;
                if (c.RFIDCheck(e.Tag.ToString(), "INSERT INTO foodorder(EmployeeIdEmployee,Date,Total,Account_RFID) VALUES(" + 1 + "," + "'" + DateTime.Now + "'" + "," + sum + "," + "'" + e.Tag.ToString() + "'" + ");"))
                    for (int j = 0; j < qArray.Length; j++)
                        if (qArray[j] > 0)
                            try
                            {
                                total += Convert.ToDouble(order.products[j].Cost() * qArray[j]);
                                n++;
                                int p = order.products[j].GetProductId();
                                c.SendQuery("INSERT INTO orderline(FoodOrder_idFoodOrder,LineNumber,Food_idFood,Quantity,UnitPrice,ExtendedPrice) VALUES (" + foodID + "," + n + "," + p + "," + qArray[j] + "," + Convert.ToDouble(order.products[j].Cost()) + "," + total + ");");
                                loggedIn = true;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                c.UpdateClientMoney(c.GetClientMoney(e.Tag.ToString()) - sum, e.Tag.ToString());
            }
            catch (Exception)
            {
                loggedIn = false;
            }
            c.DisConFromDB();
            timer.Enabled = true;
            pb_rfid.Visible = false;
            pb_rfid.Enabled = false;
            pb_Animation.Visible = true;
            pb_Animation.Enabled = true;
            OnSuccessPercuse();
        }
        private void OnSuccessPercuse()
        {
            reset?.Invoke();
        }

        //print the tag code for the tag that was just lost
        private static void rfid_TagLost(object sender, TagEventArgs e)
        {

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
                        frame = 0;
                        pb_Animation.Image = imageSuccess[3];
                        timer.Enabled = false;
                        pb_Animation.Visible = false;
                        pb_Animation.Enabled = false;
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
                        pb_Animation.Visible = false;
                        pb_Animation.Enabled = false;
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
