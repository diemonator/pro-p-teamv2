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
    public partial class FStandForm : Form
    {
        //fields

        private ConnectToPhpMyAdmin c;
        private double sum = 0;
        private const int xPos = 400;
        private const int xPosD = 1000;
        private Order order;
        private PictureBox[] tempHolder;
        private Image[] imageSuccess;
        private Image[] imageDenied;
        private Gallery gallery;
        private GeneratorDrinks drinkGenerator;
        private static int basketCounter = 0;
        private RFID rfid;


        //ctor
        public FStandForm()
        {
            InitializeComponent();
            order = new Order();
            c = new ConnectToPhpMyAdmin();           
            lb_BasketCount.ForeColor = Color.Red;
            gallery = new Gallery();
            rfid = new RFID();
            rfid.open();
            rfid.waitForAttachment();
            rfid.Antenna = true;
            rfid.LED = true;
            drinkGenerator = new GeneratorDrinks(lb_Shop);
            drinkGenerator.AddPicutureBox("food", gallery.ArrayMainFoodPB);
            drinkGenerator.AddPicutureBox("drink", gallery.ArrayMainOfPB);
            InitPictureBoxOnFrom(gallery.ArrayMainOfPB, 120, 120, xPos, -50, 100, -200);
            InitPictureBoxOnFrom(gallery.ArrayMainFoodPB, 120, 120, xPos, -50, 100, -200);
            btn_Buy.Enabled = false;
            for (int i = 0; i < gallery.ArrayDecoratorOfPB.Length; i++)
            {
                InitPictureBoxOnFromFood(gallery.ArrayDecoratorOfPB[i], 80, 80, xPosD, -50, 100, -200);
            }
            for (int i = 0; i < gallery.ArrayDecoratorFood.Length; i++)
            {
                InitPictureBoxOnFromFood(gallery.ArrayDecoratorFood[i], 80, 80, xPosD, -50, 100, -200);
            }
            drinkGenerator.AddPictureBoxToArrays("drinkDecorator", gallery.ArrayDecoratorOfPB);
            drinkGenerator.AddPictureBoxToArrays("foodDecorator", gallery.ArrayDecoratorFood);
            imageSuccess = Animation.CampSightImageToPB("img/checkin-", 93, ".png");
            imageDenied = Animation.CampSightImageToPB("img/checkOut-", 103, ".png");
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

        private void btn_Drinks_Click(object sender, EventArgs e)
        {
            ResetMain(gallery.ArrayMainOfPB);            
            ResetMain(gallery.ArrayMainFoodPB);
            GeneratorDrinks.StartNewAnimation(gallery.ArrayMainOfPB);
            btn_Drinks.Enabled = false;
            btn_Food.Enabled = true;
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {            
            ResetMain(gallery.ArrayMainFoodPB);
            ResetMain(gallery.ArrayMainOfPB);
            GeneratorDrinks.StartNewAnimation(gallery.ArrayMainFoodPB);
            btn_Drinks.Enabled = true;
            btn_Food.Enabled = false;
        }
        private void pb_Click(object sender, EventArgs e)
        {
            btn_Buy.Enabled = true;
            for (int i = 0; i < gallery.ArrayMainOfPB.Length; i++)
            {
                if (gallery.ArrayMainOfPB[i] != sender) continue;
                Resset(gallery.ArrayDecoratorOfPB);
                Resset(gallery.ArrayDecoratorFood);
                tempHolder = gallery.ArrayDecoratorOfPB[i];
                GeneratorDrinks.StartNewAnimation(gallery.ArrayDecoratorOfPB[i]);
                break;
            }
            for (int i = 0; i < gallery.ArrayMainFoodPB.Length; i++)
            {
                if (gallery.ArrayMainFoodPB[i] != sender) continue;
                Resset(gallery.ArrayDecoratorFood);
                Resset(gallery.ArrayDecoratorOfPB);
                tempHolder = gallery.ArrayDecoratorFood[i];
                GeneratorDrinks.StartNewAnimation(gallery.ArrayDecoratorFood[i]);
                break;
            }

        }
        private void Choice_Click(object sender, EventArgs e)
        {
            btn_Buy.Enabled = true;
            for (int i = 0; i < gallery.ArrayDecoratorOfPB.Length; i++)
            {
                for (int j = 0; j < gallery.ArrayDecoratorOfPB[i].Length; j++)
                {
                    if (gallery.ArrayDecoratorOfPB[i][j] != sender) continue;
                    sum += Convert.ToDouble(gallery.ListOfDecoratorDrinks[i][j].Cost());
                    lb_Shop.Items.Add(gallery.ListOfDecoratorDrinks[i][j].ToString() + " Cost : " + gallery.ListOfDecoratorDrinks[i][j].Cost());
                    order.Add(((IProduct)gallery.ListOfDecoratorDrinks[i][j]));
                    lb_sum.Text = sum.ToString();
                    lb_BasketCount.Text = (basketCounter++).ToString();
                    return;
                }
            }
            for (int i = 0; i < gallery.ArrayDecoratorFood.Length; i++)
            {
                for (int j = 0; j < gallery.ArrayDecoratorFood[i].Length; j++)
                {
                    if (gallery.ArrayDecoratorFood[i][j] != sender) continue;
                    sum += Convert.ToDouble(gallery.ListOfDecoratorFoods[i][j].Cost());
                    lb_Shop.Items.Add(gallery.ListOfDecoratorFoods[i][j].ToString() + " Cost : " + gallery.ListOfDecoratorFoods[i][j].Cost());
                    order.Add(((IProduct)gallery.ListOfDecoratorFoods[i][j]));
                    lb_sum.Text = sum.ToString();
                    lb_BasketCount.Text = ((basketCounter++).ToString());
                    return;
                }
            }
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
        private void InitPictureBoxOnFrom(PictureBox[] pb, int width, int height, int x, int y, int positionX, int positionY)
        {
            foreach (PictureBox p in Generator.ProtectedDrinkBtnGenerate(pb, btn_Drinks.Location.X + positionX, btn_Drinks.Location.Y + positionY, btn_Drinks.Location.Y + y, btn_Drinks.Location.X + x, width, height))
            {
                p.Visible = false;
                p.Click += new EventHandler(pb_Click);
                this.Controls.Add(p);
            }
        }
        private void InitPictureBoxOnFromFood(PictureBox[] pb, int width, int height, int x, int y, int positionX, int positionY)
        {
            foreach (PictureBox p in Generator.ProtectedDrinkBtnGenerate(pb, btn_Drinks.Location.X + positionX, btn_Drinks.Location.Y + positionY, btn_Drinks.Location.Y + y, btn_Drinks.Location.X + x, width, height))
            {
                p.Visible = false;
                p.Click += new EventHandler(Choice_Click);
                this.Controls.Add(p);
            }
        }
        private static Action<PictureBox[][]> Resset = delegate (PictureBox[][] pb)
        {
            for (int i = 0; i < pb.Length; i++)
                for (int j = 0; j < pb[i].Length; j++)
                {
                    pb[i][j].Visible = false;
                    pb[i][j].Enabled = false;
                }
        };
        private static Action<PictureBox[]> ResetMain = delegate (PictureBox[] pb)
         {
             for (int i = 0; i < pb.Length; i++)
             {
                 pb[i].Visible = false;
                 pb[i].Enabled = false;
             }
         };


        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (lb_Shop.Items.Count <= 0) return;          
            SetUpRFID();
            pb_rfid.Visible = true;
            pb_rfid.Enabled = true;
        }
        public void NullLists()
        {
            lb_Shop.Items.Clear();
            order.products.Clear();
            lb_BasketCount.Text = "0";
            btn_Buy.Enabled = true;            
        }

        private void SetUpRFID()
        {

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
        }
        //methods
        /// <summary>
        /// Populates the from with initial picture boxes
        /// </summary>
        /*private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lb_RemoveList.SelectedIndex;
                lb_RemoveList.Items.RemoveAt(index);
                order.products.RemoveAt(index);
            }
            catch (Exception) { }
        }*/

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
            try
            {
                int[] qArray = order.Quantity().ToArray();
                int n = 0;
                c.conToDB();
               /* try
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
                }
                return;*/
                double total = 0;
                Int32 foodID = c.GetInt32FromDB("FoodOrder_idFoodOrder", "orderline") + 1;
                Int32 visitorId = c.GetInt32FromDB("idVisitor", "visitor");
                
                if (c.RFIDCheck(e.Tag.ToString(), "INSERT INTO foodorder(Date,Total,Stand_idStand,Visitor_idVisitor) VALUES(" + "'" + DateTime.Now + "'" + "," + sum + "," + 1 + "," + visitorId+ ");"))
                    for (int j = 0; j < qArray.Length; j++)
                        if (qArray[j] > 0)
                            try
                            {
                                
                                total += Convert.ToDouble(order.products[j].Cost() * qArray[j]);
                                n++;
                                int p = order.products[j].GetProductId();
                                c.SendQuery("INSERT INTO orderline(FoodOrder_idFoodOrder,LineNumber,Food_idFood,Quantity,UnitPrice,ExtendedPrice) VALUES (" + foodID + "," + n + "," + p + "," + qArray[j] + "," + Convert.ToDouble(order.products[j].Cost()) + "," + total + ");");

                            }
                            catch (Exception ex)
                            {
                                GeneratorDrinks.StartSuccessAnim(pb_MainAnim, imageDenied);
                                MessageBox.Show(ex.ToString());
                            }
                        else
                        {

                        }
                else
                {
                    pb_MainAnim.Enabled = true;
                    pb_MainAnim.Visible = true;
                    GeneratorDrinks.StartSuccessAnim(pb_MainAnim, imageDenied);
                    return;
                }
                c.UpdateClientMoney(c.GetClientMoney(e.Tag.ToString()) - sum,e.Tag.ToString());
                GeneratorDrinks.StartSuccessAnim(pb_MainAnim, imageSuccess);
                pb_MainAnim.Enabled = true;
                pb_MainAnim.Visible = true;
                order.products.Clear();
                rfid.Attach -= new AttachEventHandler(rfid_Attach);
                rfid.Detach -= new DetachEventHandler(rfid_Detach);
                rfid.Error -= new ErrorEventHandler(rfid_Error);
                rfid.Tag -= new TagEventHandler(rfid_Tag);
                rfid.TagLost -= new TagEventHandler(rfid_TagLost);
                sum = 0;
                lb_Shop.Items.Clear();
                lb_sum.Text = sum.ToString();
                lb_BasketCount.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                lab_status.Text = ex.ToString();
                GeneratorDrinks.StartSuccessAnim(pb_MainAnim, imageDenied);
            }
            c.DisConFromDB();
            pb_rfid.Visible = false;
            pb_rfid.Enabled = false;
        }

        //print the tag code for the tag that was just lost
        private void rfid_TagLost(object sender, TagEventArgs e)
        {

        }

        private void btn_ViewList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gallery.ArrayMainOfPB.Length; i++)
                gallery.ArrayMainOfPB[i].Enabled = false;

            for (int i = 0; i < gallery.ArrayMainFoodPB.Length; i++)
                gallery.ArrayMainFoodPB[i].Enabled = false;
            btn_ViewList.Visible = false;
            btn_ViewList.Enabled = false;
            btn_backToShop.Enabled = true;
            btn_backToShop.Visible = true;
            btn_removeFromList.Visible = true;
            btn_removeFromList.Enabled = true;
            GeneratorDrinks.StartMoveAnim(tempHolder);
        }

        private void btn_backToShop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gallery.ArrayMainOfPB.Length; i++)
                gallery.ArrayMainOfPB[i].Enabled = true;

            for (int i = 0; i < gallery.ArrayMainFoodPB.Length; i++)
                gallery.ArrayMainFoodPB[i].Enabled = true;
            btn_ViewList.Visible = true;
            btn_ViewList.Enabled = true;
            btn_backToShop.Enabled = false;
            btn_backToShop.Visible = false;
            btn_removeFromList.Visible = false;
            btn_removeFromList.Enabled = false;
            GeneratorDrinks.StartMoveAnim(tempHolder);
        }

        private void btn_removeFromList_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lb_Shop.SelectedIndex;
                lb_Shop.Items.RemoveAt(index);
                order.products.RemoveAt(index);
            }
            catch (Exception) {
                lab_status.Text = "I problem accrued after removing please try again.";
            }
        }
    }
}
