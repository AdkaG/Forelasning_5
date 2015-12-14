using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11_modyfikatory_dostepu
{
    public /*sealed*/ class MyClass //sealed uniemozliwia dziedziczenie i cale skutki tego takie, ze nie mozna uzywac niektorych pol
    {
        private string private_string = "private";
        internal string internal_string = "internal";
        internal protected string int_prot_string = "internal_protected";
        public string public_string = "public";
        protected string protected_string = "protected";
    }
}
//abstract - zmusza do dziedziczenia
//sealed - zabrania dziedziczenia
