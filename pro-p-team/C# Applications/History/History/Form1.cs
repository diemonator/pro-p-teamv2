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
using MySql.Data.MySqlClient;

namespace History
{
    public partial class Form1 : Form
    {

        ConnectToPhpMyAdmin c = new ConnectToPhpMyAdmin();
        string[] queriesCustomer;
        string[] queriesEventData;


        public Form1()
        {
            InitializeComponent();
            c.conToDB();
            queriesCustomer = new string[1];
            queriesEventData = new string[3];
        }
        public string[] QueryCustomerDataResult(string[] queriesCustomer)
        {
            string[] results = c.GetInfoFromDBToString(queriesCustomer);
            string[] temp = new string[results.Length];
            for (int i = 0; i < queriesCustomer.Length; i++)
            {
                temp[i] = results[i].Split(';')[1];
            }
            return temp;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         


        }
        public string[] QueryEventDataResult(string[] queriesEventData)
        {
            string[] results = c.GetInfoFromDBToString(queriesEventData);
            string[] temp = new string[results.Length];
            for (int i = 0; i < queriesEventData.Length; i++)
            {
                temp[i] = results[i].Split(';')[1];
            }
            return temp;
        }

        private void btnGetCurrentStatus_Click(object sender, EventArgs e)
        {
           
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = tb_CustomerName.Text;
            queriesCustomer[0] = "SELECT * FROM visitor WHERE Name = " + "'" + name + "'" + ";";
            try
            {
                lb_HistoryList.Items.Clear();
                // lb_HistoryList.Items.Add("*********" + tb_CustomerName.Text + "'s info:" + "*************");

                string[] array = QueryCustomerDataResult(queriesCustomer);
                string[] arrayInfo = array[0].Split(' ');
                lb_HistoryList.Items.Add("ID: " + arrayInfo[0].ToString());
                lb_HistoryList.Items.Add("Number: " + arrayInfo[1].ToString());
                lb_HistoryList.Items.Add("Fisrt Name: " + arrayInfo[2].ToString());
                lb_HistoryList.Items.Add("Last Name: " + arrayInfo[3].ToString());
                lb_HistoryList.Items.Add("Address: " + arrayInfo[4].ToString());
                if (arrayInfo[5] == "TRUE")
                {
                    lb_HistoryList.Items.Add("In event : Yes");
                }
                else
                {
                    lb_HistoryList.Items.Add("In event : No");
                }
                if (arrayInfo[6] == "TRUE")
                {
                    lb_HistoryList.Items.Add("Did he leave? : Yes");
                }
                else
                {
                    lb_HistoryList.Items.Add("Did he leave? : Not paricipating");
                }






            }
            catch (FormatException)
            {

                MessageBox.Show("Enter correct values!");
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter valid information!");
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            queriesEventData[0] = "SELECT COUNT(*) FROM Visitor;"; //all visitors
            queriesEventData[1] = "SELECT COUNT(HasEntered) FROM Visitor WHERE HasEntered = 1;"; //current visitors
            queriesEventData[2] = "SELECT COUNT(HasEntered) FROM Visitor WHERE HasEntered = 0;"; //ones who left


            string[] array = QueryEventDataResult(queriesEventData);

            try
            {
                lb_HistoryList.Items.Clear();
                lb_HistoryList.Items.Add("********EVENT INFO**********");
                lb_HistoryList.Items.Add("Total visitors count: " + array[0].ToString());
                lb_HistoryList.Items.Add("Current visitors: " + array[1].ToString());
                lb_HistoryList.Items.Add("Visitors that left: " + array[2].ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {
            
        }
    }


}

