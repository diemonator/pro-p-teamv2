using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntranceAppProP;

namespace EntranceClientApp
{
    public class Client : IClient
    {
        public delegate void NewClientHandler(string s);
        public event NewClientHandler NewRegistration;

        private readonly List<Activeties> activeties;
        private string firstName;
        private string lastName;
        private string address;
        private static int clientId;
        private string bankInfo;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }
        public string BankInfo
        {
            get
            {
                return bankInfo;
            }

            set
            {
                bankInfo = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }


        public Client(string firtstName, string lastName, string bankInfo, string address)
        {
            activeties = new List<Activeties>();
            ClientId++;
            FirstName = firtstName;
            LastName = lastName;
            BankInfo = bankInfo;
            Address = address;
        }

        public void OnNewRegistration(string info)
        {
            NewRegistration?.Invoke(info);
        }

        public void Refresh(string info)
        {
            EventNewRegistration(info);
        }

        public void AddClient(Activeties a)
        {
            a.NewRegisterIsUp += OnNewRegistration;
            activeties.Add(a);
        }

        public void RemoveClient(Activeties a)
        {
            a.NewRegisterIsUp -= OnNewRegistration;
            activeties.Remove(a);
        }

        public void EventNewRegistration(string info)
        {
            NewRegistration?.Invoke(info);
        }

        public bool IsRegistered(Activeties a)
        {
            return activeties.Contains(a);
        }
        public override string ToString()
        {
            return this.FirstName + " - " + LastName;
        }
    }
}
