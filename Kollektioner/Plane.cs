using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Plane : IComparable<Plane>//TO
    {
        public int Seats { get; private set; }
        public int Pilots { get; private set; }
        public Plane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public int CompareTo(Plane obj)//TO
        {
            return obj.Seats.CompareTo(this.Seats);//returnerar -1, 0 lub 1
        }
        public override string ToString() => $"Seats: {Seats}, Pilots: {Pilots}";

    }
}//Liskov - zawsze private set;
