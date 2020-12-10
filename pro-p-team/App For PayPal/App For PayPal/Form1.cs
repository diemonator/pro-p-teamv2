using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace App_For_PayPal
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = null;
        List<PayPal> PayPalEntities;
        List<string> lines;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "TXT(LOG)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                txtBox.Text = sr.ReadToEnd();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            if (ofd != null)
            {
                PayPalEntities = new List<PayPal>();
                lines = File.ReadAllLines(ofd.FileName).ToList();
                lines = Algorithems.SplitterToLists(lines);
                // lines = SplitMethod(lines);

                int counter = 0;
                PayPal newEntity = new PayPal();
                bool lastSwitch = true;
                foreach (var line in lines)
                {

                    counter++;
                    switch (counter)
                    {

                        case 1:
                            newEntity.BankAccountOrg = Convert.ToInt32(line);
                            break;
                        case 2:
                            newEntity.StarPeriod = Convert.ToDateTime(line);
                            break;
                        case 3:
                            newEntity.EndPeriod = Convert.ToDateTime(line);
                            break;
                        case 4:
                            newEntity.NrOfDeposits = Convert.ToInt32(line);
                            break;
                        default:
                            if (lastSwitch)
                            {
                                newEntity.DepositId = Convert.ToInt32(line);
                                lastSwitch = false;
                            }
                            else
                            {
                                newEntity.DepositAmount = Convert.ToDouble(line);
                                lastSwitch = true;
                            }

                            break;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (PayPal item in PayPalEntities)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
