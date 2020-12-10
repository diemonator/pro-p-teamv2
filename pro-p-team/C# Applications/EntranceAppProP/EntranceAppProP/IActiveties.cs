using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntranceAppProP
{
    public interface IActiveties
    {
        void UpdateClients(string d);
        void Attach();
        void Detach();
    }
}
