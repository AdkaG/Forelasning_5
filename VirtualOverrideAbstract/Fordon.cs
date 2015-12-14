using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Fordon
    {
        public virtual void Print()
        {
            Console.WriteLine("Fordon");
        }

        public void NewPrint()
        {
            Console.WriteLine("Fordon - new");
        }
    }
}
