using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Bulb
    {
        int h;//0-360
        byte s;//0-100
        byte l;//0-100

        public int H
        {
            get
            {
                return h;
            }

            set
            {
                var validValue = value >= 0 && value <= 360;
                if (validValue)
                    h = value;
                else
                    throw new Exception("Wrong value.");
            }
        }
        public byte S
        {
            get
            {
                return s;
            }

            set
            {
                var validValue = value >= 0 && value <= 100;
                if (validValue)
                    s = value;
                else
                    throw new Exception("Wrong value.");
            }
        }
        public byte L
        {
            get
            {
                return l;
            }

            set
            {
                var validValue = value >= 0 && value <= 100;
                if (validValue)
                    l = value;
                else
                    throw new Exception("Wrong value.");
            }
        }

        public Bulb()
        {
            H = 0;
            S = 50;
            L = 50;
        }
        public Bulb(int h)
        {
            H = h;
            S = 33;
            L = 77;
        }
        public Bulb(int h, byte s)
        {
            H = h;
            S = s;
            L = 100;
        }

        //tylko ostatni tak naprawde potrzebny
        public Bulb(int h, byte s = 50, byte l = 50)
        {
            H = h;
            S = s;
            L = l;
        }//default na koncu!!!

        public override string ToString() => $"H: {h}, S: {s}, L: {l}";
       //onerow method
    }
}
//cto konstruktor
//ove and inteli i mamy cala metode ostatnia ze stringiem
