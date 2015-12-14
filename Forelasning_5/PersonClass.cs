using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_5
{
    class PersonClass
    {
        private string name;
        private int age;
        private Address address;
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
private class Address
        {
            string street;
            int streetNumber;
            public string GetStreet()
            {
                return street;
            }
            public void SetStreet(string street)
            {
                this.street = street;
            }
        }//dokonczyc
    }
}
