using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    abstract class VehicleAbstr
    {
        //abstract innebär att vi lämnar över allt ansvar till underliggande klasser
        public abstract void Print();
    }
    class VehicleDeriv : VehicleAbstr
    {
        public override void Print()
        {
            Console.WriteLine("Ext. method Print from abstract class.");
        }
    }
}
