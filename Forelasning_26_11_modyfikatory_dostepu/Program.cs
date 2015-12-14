using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11_modyfikatory_dostepu
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.int_prot_string = "Nytt värde";
            myClass.internal_string = "Nytt värde";
            myClass.public_string = "Nytt värde";
        }
    }
}
