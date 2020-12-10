using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearWithMeLibs;
using MySql.Data;
using Phidgets;
using Phidgets.Events;

namespace ISSDappProP
{
    public partial class SDapp : Form
    {
        Order order = new Order();
        Store ISSD;
        private ConnectToPhpMyAdmin c;
        private RFID rfid;

        public SDapp()
        {
            InitializeComponent();
            ISSD = new Store();
            c = new ConnectToPhpMyAdmin();
            rfid = new RFID();
        }

        //methods
        private void SetUpRFID()
        {
            rfid.open();
            rfid.waitForAttachment();
            rfid.LED = true;
            rfid.Antenna = true;
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
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
            int n = 0;
            c.conToDB();
            try
            {
                ITech[] temp;
                int line = 0;

                Int32 rentID = c.GetInt32FromDB("idRent", "rent") + 1;
                Int32 v = c.GetVisitorIDFromDB("idVisitor", e.Tag.ToString());
                c.SendQuery("INSERT INTO rent (Date,Total,Stand_idStand,Visitor_idVisitor) VALUES(" + "'" + DateTime.Now + "'" + ", " + order.total() + ", " + 2 + "," + v + ");");

                temp = order.getItems().ToArray();
                ITech[] newTemp = order.getItems().Distinct().ToArray();
                int x = 0;
                int y = 0;

                for (int i = 0; i < newTemp.Length; i++)
                {


                    if (newTemp[i].TechName() == GetNameAtIndex(i))
                    {
                        x++;
                    }
                    line++;
                    try
                    {
                        int id = newTemp[i].GetId();
                        int amount = GetQuantity(newTemp[i].TechName());
                        double price = getPrice(newTemp[i].TechName());
                        n++;
                        c.SendQuery("INSERT INTO rentline (Line, Rent_idRent, Item_idItem, Quantity, UnitPrice, ExtendedPrice, Line_LineNumber)" +
                        "VALUES (" + line + " , " + rentID + " , " + id + " , " + amount + " , " + price + " , " + (amount * price) + " , " + n + ");");
                        c.SendQuery("UPDATE item SET Count = Count -1 WHERE idItem= " + id + ";");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                //GeneratorDrinks.StartSuccessAnim(pb_MainAnim, imageSuccess);
                //pb_MainAnim.Enabled = true;
                //pb_MainAnim.Visible = true;

                lbOrder.Items.Clear();
                order = new Order();
            }
            catch (Exception)
            {
                MessageBox.Show("it did not work");
            }
            c.UpdateClientMoney(c.GetClientMoney(e.Tag.ToString()) - order.total(), e.Tag.ToString());
            c.DisConFromDB();
            MessageBox.Show("Thank you for renting at our stand!");
            label2.Text = "Please select the items that you want to rent";

        }
        //print the tag code for the tag that was just lost
        private void rfid_TagLost(object sender, TagEventArgs e)
        {


        }

        public int GetMatchingId(string name)
        {
            int temp = 0;
            foreach (ITech i in order.getItems().Distinct())
            {
                foreach (ITech j in ISSD.GetInventory().Distinct())
                {
                    if (i.TechName() == name && i.TechName() == j.TechName())
                    {
                        temp = j.GetId();
                    }
                }
            }
            return temp;
        }

        public string GetNameAtIndex(int i)
        {
            List<ITech> temp = order.getItems();
            return temp[i].TechName();
        }
        public int GetQuantity(string name)
        {
            int counter = 0;
            ITech[] array = order.getItems().OrderBy(x => x.ToString()).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].TechName() == name)
                {
                    counter++;
                    array[i] = null;
                    continue;
                }
            }
            return counter;


        }
        public double getPrice(string name)
        {
            double temp = 0;
            foreach (ITech i in order.getItems())
            {
                if (i.TechName() == name)
                {
                    temp = i.Cost();
                }
            }
            return temp;
        }

        public string getDescription(string name)
        {
            string temp = "";
            foreach (ITech item in order.getItems())
            {
                if (item.TechName() == name)
                {
                    temp += item.TechName();
                }
            }
            return temp;
        }
        //end  methods
        //no mas methods here
        //useless things??

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //buying button
        private void btn_Drinks_Click(object sender, EventArgs e)
        {
            label2.Text = "Please place your card on the scanner";
            SetUpRFID();
            


            //for (int i = 0; i < ISSD.GetInventory().Count; i++)
            //{
            //    c.SendQuery("INSERT INTO item (Description,UnitPrice) VALUES (" + "'" + ISSD.GetInventory()[i].TechName() + "'" + "," + ISSD.GetInventory()[i].Cost() + ");");
            //}
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {

        }

        private void lbX_Click(object sender, EventArgs e)
        {
            rfid.close();
            this.Close();
        }

        private void pictureBoxClick(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            for (int i = 0; i < ISSD.GetInventory().Count; i++)
            {
                if (b.Name == "pb" + ISSD.GetInventory()[i].TechName())
                {
                    order.AddToList(ISSD.GetInventory()[i]);
                    lbOrder.Items.Add(ISSD.GetInventory()[i].ToString());
                }
            }
        }

        private void btn_create_new_order_Click(object sender, EventArgs e)
        {
            lbOrder.Items.Clear();
            order = new Order();
            MessageBox.Show("Please choose the item(s) that you want to rent");
        }

        private void btn_return_item_Click(object sender, EventArgs e)
        {
            c.conToDB();
            int x = 0;
            ITech[] newTemp = order.getItems().Distinct().ToArray();
            for (int i = 0; i < newTemp.Length; i++)
            {
                if (newTemp[i].TechName() == GetNameAtIndex(i))
                {
                    x++;
                }
                try
                {
                    int id = newTemp[i].GetId();
                    c.SendQuery("UPDATE item SET Count = Count +1 WHERE idItem= " + id + ";");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            MessageBox.Show("Item Returned!");
            lbOrder.Items.Clear();
            c.DisConFromDB();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
