using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverride
{
    struct Bike
    {
        private int val, min, max;//växlar: vald, min, max

        public int Val
        {
            get { return val; }
            set
            {
                if (value >= min && value <= max)
                    val = value;
                else
                    val = min;
            }
        }

        public Bike(int min, int max)
        {
            val = min;
            this.min = min;
            this.max = max;
        }

        public static Bike operator +(Bike bike, int tal)
        {
            bike.max += tal;
            return bike;
        }
        public static Bike operator -(Bike bike, int tal)
        {
            bike.max -= tal;
            return bike;
        }
        public static int operator +(int tal, Bike bike)
        {
            bike.max += tal;
            return tal;
        }
        public static Bike operator *(Bike bike, int tal)
        {
            bike.max *= tal;
            return bike;
        }
        public static Bike operator /(Bike bike, int tal)
        {
            bike.max /= tal;
            return bike;
        }

        public static Bike operator ++(Bike bike)
        {
            bike.max += 1;
            return bike;
        }
        public static Bike operator --(Bike bike)
        {
            bike -= 1;
            return bike;
        }
        public static bool operator ==(Bike bike1, Bike bike2)
        {
            return bike1.min == bike2.min;

        }
        public static bool operator !=(Bike bike1, Bike bike2)
        {
            return bike1.min != bike2.min;
        }
        public static bool operator >=(Bike bike1, Bike bike2)
        {
            return bike1.min >= bike2.min;
        }
        public static bool operator <=(Bike bike1, Bike bike2)
        {
            return bike1.min <= bike2.min;
        }
        public static bool operator >(Bike bike1, Bike bike2)
        {
            return bike1.min > bike2.min;
        }
        public static bool operator <(Bike bike1, Bike bike2)
        {
            return bike1.min < bike2.min;
        }

        public override string ToString()
        {
            return $"Val: {Val}, Min: {min}, Max:{max}";
        }
    }
}
