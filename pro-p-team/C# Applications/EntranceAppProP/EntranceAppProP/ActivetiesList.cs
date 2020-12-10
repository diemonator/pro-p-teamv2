using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceAppProP
{
    public class ActivetiesList
    {
        public delegate void ActivetiesHandeler(Activeties a);
        public event ActivetiesHandeler ActivetieAdded;
        public event ActivetiesHandeler ActivetieRemoved;
        private readonly List<Activeties> activeties;

        public ActivetiesList()
        {
            activeties = new List<Activeties>();
        }

        public void OnActivetiesAdded(Activeties a)
        {
            ActivetieAdded?.Invoke(a);
        }
        public void OnActivetiesRemoved(Activeties a)
        {
            ActivetieRemoved?.Invoke(a);
        }
        private bool ActivetieExists(string name, string location)
        {
            return GetActivetie(name, location) != null;
        }
        public string AddActivetie(string name, string location, decimal price)
        {
            if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(location))
            {
                if (!ActivetieExists(name, location))
                {
                   
                    Activeties a = new Activeties(name, location, price);
                    string query = "INSERT INTO Events VALUES(" + a.ActiveId + "," + "'" + a.NameOfActivetie + "'" + "," + "'" + a.Location + "'" + "," + a.PriceActive + ");";
                    
                    activeties.Add(a);
                    OnActivetiesAdded(a);
                    return "Successfully added!";
                }
                else
                {
                    return "Activetie already exists!";
                }

            }
            else
            {
                return "Activetie cant be empty!";
            }
        }
        public string RemoveActivetie(string name, string location)
        {
            Activeties a = GetActivetie(name, location);
            if (a != null)
            {

                activeties.Remove(a);
                OnActivetiesRemoved(a);
                return "Successfully removed!";
            }
            else
            {
                return "Activetie doesn't exist";
            }


        }
        private Activeties GetActivetie(string name, string location)
        {
            foreach (Activeties a in activeties)
            {
                if (a.NameOfActivetie == name && a.Location == location)
                {
                    return a;
                }
            }
            return null;
        }
        public Activeties GetIndex(int index)
        {
            if (activeties.Count != 0 && index >= 0)
            {
                return activeties[index];
            }
            else
            {
                return null;
            }
        }
        public List<Activeties> GetList()
        {
            return activeties;
        }
    }
}
