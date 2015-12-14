using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int age;
        string name;
        public Person()
        {
            age = 0;
        }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
