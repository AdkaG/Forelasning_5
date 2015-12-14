using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* en egendefinierade VÄRDEtyp
* implicite sealed
* uzywamy do koordynatow np., proste pola z prostymi danymi
* max 5 fields
* peckar på stocken, inte på heapen som t.ex. class
* alla primitiva typerna är struktar
* int, long, double, float, decimal, char, DateTime, bool (nie moze byc null bo jest na heapie)
* ok. 3 razy szybszy niz klasa gdy 5 pol jest
*/
namespace Structs
{
    struct Koordinat
    {
        public int X; //duza litera bo sa publiczne
        public int Y;
        public string Z;//pole ma kontakt z heapen - to moze! sama struct nie moze
        //public int Z = 7;//nie moze miec wartosci, does not compute
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z:{Z}";
        }
    }
    
}

