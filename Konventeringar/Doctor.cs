using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteringar
{
    class Doctor : Person
    {
        public int YearsOfPractise { get; set; }
       public Doctor(int age, int yearsOfPractise) : base(age)
        {
            YearsOfPractise = yearsOfPractise;
        }
        public override string ToString() => $"{base.ToString()}, YearsOfPractise: {YearsOfPractise}";
       
    }
}
