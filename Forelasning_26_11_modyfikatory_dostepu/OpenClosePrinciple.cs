using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11_modyfikatory_dostepu
{
    class OpenClosePrinciple
    {
        internal int MyProperty { get; private set; }//najwyzszy stopien zabezp.
        internal int MyProperty2 { get; private set; }//najwyzszy stopien zabezp.
        //po pierwsze z internal na public
        //po drugie pomijamy privat przy set

        public int Comfortable { get; set; }//najmniej zabezp.

        public OpenClosePrinciple(int myProperty, int myProperty2)
        {
            MyProperty = MyProperty;
            MyProperty2 = MyProperty2;
        }
    }
}
//roznica z readonly ???
