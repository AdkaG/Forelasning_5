using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Bus
    {
        public int Seats { get; set; }
        public int HorsePower { get; set; }
        public Bus(int seats, int horsePower)
        {
            Seats = seats;
            HorsePower = horsePower;
        }
        public override string ToString() => $"Seats: {Seats}, HorsePower: {HorsePower}";
       
    }
}
