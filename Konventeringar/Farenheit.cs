using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konventeringar
{
    class Farenheit
    {
        public float Temp { get; private set; }

        public Farenheit(float temp)
        {
            Temp = temp;
        }
        public static explicit operator Celsius(Farenheit farenheit)
        {
            return new Celsius(5.0f/9.0f * (farenheit.Temp - 32));
        }
    }
}
// F= (9.0f/5.0f)*celsius.Temp + 32
// F-32 = (9.0/5.0) * celsius.Temp
//(F-32)/(9.0/5.0) = cel.Temp