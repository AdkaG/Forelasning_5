using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11
{
    class Bicycle : Vehicle
    {
        public int Spokes { get; set; }
        public override string ToString() //=> string.Format("Spokes: {0} {1}", Spokes, base.ToString()); //1 sposob
        {
            //2 sposob:
            return string.Format("Spokes: {0} {1}", Spokes, base.ToString());

            // 3 sposob: 
            //return $"Spokes: {Spokes} {base.ToString()}"
            
            //base.ToString() - odwolanie do klasy bazowej, drukuje to co jej metoda ToString()
            //prints in console:  Spokes: ... Wheels: ... Passengers: ...

        }
    }
}
