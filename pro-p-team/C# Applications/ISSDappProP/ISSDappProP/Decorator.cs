using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSDappProP
{
    abstract class Decorator: ITech
    {
        override abstract public string ToString();
        abstract public void TechCount();
        abstract public void TechId(int i);
        abstract public int GetId();
        abstract public double Cost();
        abstract public string TechName();
    }
}
