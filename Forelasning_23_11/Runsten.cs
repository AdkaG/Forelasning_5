
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Runsten
    {
        string name;
        int weight;
        int age;

        public string Name
        {
            get { return name; }
            set
            {
                var isBigCharFirst = value[0].ToString().ToUpper() == value[0].ToString();
                var validValue = value != null && isBigCharFirst;
                if (validValue)
                    name = value;
                else
                    throw new Exception("Wrong input.");
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                var validValue = value != 0 && value >= 100 && value <= 7000;
                if (validValue)
                    weight = value;
                else
                    throw new Exception("Det är rymdskepp.");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value != 0 && value >= 400 && value <= 1200)
                    age = value;
                else
                    throw new Exception("What?");
            }
        }

        public Runsten()
        {
            Name = "Elf";
            Weight = 800;
            Age = 600;
        }
        public Runsten(string name)
        {
            Name = name;
            Weight = 2000;
            Age = 1200;
        }
        public Runsten(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Age = 1000;
        }
        public Runsten(string name = "Sigma", int weight = 500, int age = 500)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
    }
}
