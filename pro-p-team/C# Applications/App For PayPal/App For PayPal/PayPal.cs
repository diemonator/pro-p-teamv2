using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace App_For_PayPal
{
    [DataContract]
    public class PayPal
    {
        [DataMember]
        public List<int> depositId;
        [DataMember]
        public List<double> amount;
        [DataMember]
        public int BankAccountOrg { get; set; }
        [DataMember]
        public DateTime StarPeriod { get; set; }
        [DataMember]
        public DateTime EndPeriod { get; set; }
        [DataMember]
        public int NrOfDeposits { get; set; }

        public PayPal(int bank, DateTime start, DateTime end, int deposits)
        {
            BankAccountOrg = bank;
            StarPeriod = start;
            EndPeriod = end;
            NrOfDeposits = deposits;
            this.depositId = new List<int>();
            this.amount = new List<double>();
        }

        public void AddDepositId(int depoid)
        {
            depositId.Add(depoid);
        }

        public void AddDepAmounth(double amount)
        {
            this.amount.Add(amount);
        }

        public List<int> GetDeposit()
        {
            return depositId;
        }

        public List<double> GetAmount()
        {
            return amount;
        }
    }
}