using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Bicycle : Fordon
    {
        public override void Print()
        {
            Console.WriteLine("Bicycle");
        }
        public new void NewPrint()
        {
            Console.WriteLine("Bicycle - new");
        }
    }
}
