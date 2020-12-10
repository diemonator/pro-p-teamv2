using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntranceAppProP;

namespace EntranceClientApp
{
  public interface IClient
    {
        void AddClient(Activeties a);
        void Refresh(string infoEmp);
        void RemoveClient(Activeties a);
    }
}
