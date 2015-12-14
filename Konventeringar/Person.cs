using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteringar
{
    class Person
    {
        public int Age { get; set; }
       public Person(int age)
        {
            Age = age;
        }
        public override string ToString() => $"Age: {Age}";
       
    }
}
