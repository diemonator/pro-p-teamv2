using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSDappProP
{
    interface ITech
    {
        string TechName();
        void TechCount();
        void TechId(int i);
        int GetId();
        double Cost();
        string ToString();
    }
}
