using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverteringar
{
    class Surgeon:Doctor
    {
        public int NumberOfOperations { get; set; }
       public Surgeon(int age, int yearsOfPractise, int numberOfOperations):base(age, yearsOfPractise)
        {
            NumberOfOperations = numberOfOperations;
        }
        public override string ToString() => $"{base.ToString()}, NumberOfOperations: {NumberOfOperations}";
        
    }
}
