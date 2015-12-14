using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class IndexerWithAccessMethods
    {
        int counter = 0;
        string[] values = new string[10]; //backing field => backing store
        private string this[int index]
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
        public void AddString(string text)//bo nie wierzymy tym co wpisuja, nie moga robic co chca, tylko przez te metode
        {
            if (counter < values.Length)
                values[counter] = text;
            counter++;

        }
    }
}
