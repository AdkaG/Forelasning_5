using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Point
    {
        public int X;
        public int Y;
        //public string Z; moze byc, nie powinno 
        //aby utworzyc konstruktor musze zawrzec w nim wszystkie pola, bo inaczej ustawi pole na zero ja domyslnie

        public Point(int x) //przynjamniej jedna zmienna
        {
            X = x;
            Y = 7;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int AddXy()
        {
            return X + Y;
        }
    }
}
