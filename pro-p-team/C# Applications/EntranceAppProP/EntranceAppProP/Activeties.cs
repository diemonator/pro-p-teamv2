using System.Collections.Generic;
//using SimpleTCP;

namespace EntranceAppProP
{
   public class Activeties : IActiveties
    {
        public delegate void UpdateRegisterHandler(string arg);
        public event UpdateRegisterHandler NewRegisterIsUp;        
        private static int activeId;
        private string location;
        private string nameOfActivetie;
        private decimal priceActive;
        //private string host = "127.0.0.1";
        //private int port = 8080;
        //private SimpleTcpServer server;

        public int ActiveId
        { get {return activeId;} set  {  activeId = value; } }

        public string NameOfActivetie
        {
            get
            {
                return nameOfActivetie;
            }

            set
            {
                nameOfActivetie = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public decimal PriceActive
        {
            get
            {
                return priceActive;
            }

            set
            {
                priceActive = value;
            }
        }

        public Activeties(string name , string location,decimal price)
        {            
            NameOfActivetie = name;
            Location = location;
            PriceActive = price;
            ActiveId++;
            //server = new SimpleTcpServer();
            //server.Delimiter = 0x13;// button enter
            //server.DataReceived += SERVER_DATARECIEVED;
        }
        //private void SERVER_DATARECIEVED(object sender, SimpleTCP.Message e)
        //{
        
        //}
        public void UpdateClients(string d)
        {
            if (!string.IsNullOrWhiteSpace(d))
            {
                NewRegisterIsUp?.Invoke(d);
            }
        }

        public void Attach()
        {
            
        }

        public void Detach()
        {
            
        }
        public int GetAmountOfParticipents()
        {
            return 0;
        }
        public override string ToString()
        {
            return NameOfActivetie + " - " + Location;
        }
    }
}
