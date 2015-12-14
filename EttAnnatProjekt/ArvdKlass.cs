using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning_26_11_modyfikatory_dostepu;

namespace EttAnnatProjekt
{
    class ArvdKlass : MyClass
    {
        public void Smth()
        {
            //base.// dostep jak w normalnej dziedziczonej bez internal bo to inny projekt
            base.public_string = "";
            base.protected_string = "";
            base.int_prot_string = "";
            
        }
    }
}
