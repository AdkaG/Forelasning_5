using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer2 test = new Indexer2();
            test[0] = "Book 1";
            test[1] = "Book 2";
            test[7] = "Book 8";

            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}
//en array av instancer av en klass
//icke static
//this som nickelord/identifierare
//signatur: returtyp this[inparam]{get{}set{}}
