using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntranceAppProP
{
    public class ActivetieView : IActivetieView
    {
        private readonly ListBox lb;

        public ActivetieView(ListBox lb)
        {
            this.lb = lb;
        }

        public void AddToActiveties(Activeties a)
        {
            lb.Items.Add(a);
        }

        public void RemoveFromActiveties(Activeties a)
        {
            lb.Items.Remove(a);
        }
    }
}
