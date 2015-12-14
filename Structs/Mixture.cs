using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Mixture
    {
        public bool MyBool;
        public double MyDouble;
        public long MyInt;

        public Mixture(bool myBool, double myDouble, long myLong)
        {
            MyBool = myBool;
            MyDouble = myDouble;
            MyInt = myLong;
        }

        public override string ToString()
        {
            return $"MyBool: {MyBool}, MyDouble: {MyDouble}, MyInt: {MyInt}";
        }
    }
}
