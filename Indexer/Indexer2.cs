using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Indexer2
    {
        string[] values = new string[10]; //backing field => backing store
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < values.Length)//kontroll på att man hämtar värden inom range
                    return values[index];
                else
                    throw new Exception("Out of range.");
            }
            set
            {
                if (index >= 0 && index < values.Length)
                    values[index] = value;
                else
                    throw new Exception("Out of range.");

            }
        }
    }
}
