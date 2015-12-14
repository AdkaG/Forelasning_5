using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Bicycle
    {
        private int gears;
        private string brand;

        public int Gears
        {
            get { return gears; }//jesli podamy niemieszczaca sie wartosc to poda wartosc default czyli 0
            set
            {
                //introducerar en förklarande variabel till det kryptiska
                //boolska värdet - ctrl + .
                var validGears = value >= 0 && value <= 30;
                if (validGears)
                    gears = value;
                //else
                   //throw new Exception - bedzie pozniej
                        }
        }
        public string Brand
        {
            get { return brand; }
            set
            {
                if (value != null && value.Length >= 3)
                    brand = value;
            }
        }

    }
}
//Ctrl + .
