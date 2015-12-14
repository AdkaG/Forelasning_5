using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konventeringar
{
    class Celsius
    {
        public float Temp { get; private set; }

        public Celsius(float temp)
        {
            Temp = temp;
        }
        //explicit typkonvertering
        public static explicit operator Farenheit(Celsius celsius)
        {
            return new Farenheit((9.0f/5.0f)*celsius.Temp + 32);
        }
    }
}
