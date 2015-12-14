using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class MyBil : Fordon
    {
        public override void Print()
        {
            Console.WriteLine("Bil");
        }
        new public void NewPrint()
        {
            Console.WriteLine("Bil - new");
        }
    }
}
