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
        public int BankAccountOrg { get; set; }
        [DataMember]
        public DateTime StarPeriod { get; set; }
        [DataMember]
        public DateTime EndPeriod { get; set; }
        [DataMember]
        public int NrOfDeposits { get; set; }
        [DataMember]
        public int DepositId { get; set; }
        [DataMember]
        public double DepositAmount { get; set; }

     
    }
}
