using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_Fredag20_11
{
    class Class1
    {
        //Egenskaper för Class1;
        // - Datamedlemmar, field, fält
        // - Konstanter
        // vi kan göra dessa : private, public, static, const
        public static int reachableNumber;
        private static int notReachableNumber;
        public const double PI = 3.141592654; //const är implicit static
        /*
        Funktionella medlemmar:
         - Metoder
         - Properties
         - Constructor
         - Destructor
         - Operators
         - Indexer
         - Event
        */
        public static void SetNumber(int number)//musi byc static tez; nie mozna uzyc this, nie ma instancji, konflikt nazwy bo  nie moze byc wielu takich zmiennych, bo jest static
        {
            notReachableNumber = number;
        }
    }
}
