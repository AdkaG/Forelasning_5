using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11_modyfikatory_dostepu
{
    class MySubClass: MyClass
    {
       
        public void PrintAll()
        {
            base.internal_string = "värde"; //base tylko po to by miec int.s.
            public_string = "värde";//mozna bez base
            base.protected_string = "värde";
            base.int_prot_string = "värde";

        }
    }
}
