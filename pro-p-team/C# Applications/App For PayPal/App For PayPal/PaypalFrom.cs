using System;
using System.Globalization;
using BearWithMeLibs;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace App_For_PayPal
{
    public partial class PaypalFrom : Form
    {
        //images 
        private OpenFileDialog ofd = null;
        private PayPal attribute;

        public PaypalFrom()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "TXT(LOG)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                ConnectToPhpMyAdmin connection = new ConnectToPhpMyAdmin();
                try
                {
                    connection.conToDB();
                    List<string> temp = new List<string>();
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string s = null;
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        temp.Add(s);
                        txtBox.AppendText(s + '\n');
                    }
                    try
                    {
                        string start = Convert.ToString(temp[1]);
                        string end = Convert.ToString(temp[2]);
                        DateTime startPeriod = DateTime.ParseExact(start, "yyyy/MM/dd/HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime endPeriod = DateTime.ParseExact(end, "yyyy/MM/dd/HH:mm:ss", CultureInfo.InvariantCulture);
                        attribute = new PayPal(Convert.ToInt32(temp[0]), startPeriod, endPeriod, Convert.ToInt16(temp[3]));
                        int i = 1;
                        foreach (string item in temp)
                        {
                            if (item.Contains(" "))
                            {
                                foreach (string element in item.Split(' '))
                                {
                                    if (i % 2 > 0)
                                        attribute.AddDepositId(int.Parse(element));
                                    else
                                        attribute.AddDepAmounth(double.Parse(element));
                                    i++;
                                }
                            }
                        }
                        string format = "yyyy-MM-dd HH:mm:ss";
                        connection.SendQuery("INSERT INTO paypal(idPayPal,StartPeriod,EndPEriod,NrOfDeposits) VALUES (" + attribute.BankAccountOrg + "," + "'" + attribute.StarPeriod.ToString(format) + "'" + "," + "'" + attribute.EndPeriod.ToString(format) + "'" + "," + attribute.NrOfDeposits + ");");
                        for (int y = 0; y < attribute.NrOfDeposits; y++)
                        {
                            List<int> depId = attribute.GetDeposit();
                            List<double> depAmount = attribute.GetAmount();
                            connection.SendQuery("INSERT INTO depositline(idDepositLine,Amount,PayPal_idPayPal,Visitor_idVisitor) VALUES(" + i + "," + Convert.ToInt32(attribute.amount[i]) + "," + attribute.BankAccountOrg + "," + attribute.depositId[i] + ");");
                       }
                        
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    sr?.Close();
                    connection.DisConFromDB();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
