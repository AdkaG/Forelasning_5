using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Tractor
    {
        int wheels;
        int steeringAngle;

        public int Wheels
        {
            get { return wheels; }
            set
            {
                if (value >= 3 && value <= 20)
                    wheels = value; //przy Wheels wysadza program, bo loop infinit, mozna pisac this.wheels
                else
                    throw new Exception("Fel värde satt måste vara 3-20.");
            }
        }
        public int SteeringAngle
        {
            get { return steeringAngle; }
            set
            {
                steeringAngle = value % 360;
            }
        }

        public Tractor() //w konstruktorze uzywamy properties aby zachowac walidacje
        {
            Wheels = 4;
            SteeringAngle = 0;
        }
        public Tractor(int wheels)// tu tez properties aby zachowac walidacje
        {
            Wheels = wheels;
            SteeringAngle = 0;
        }
        public Tractor(int wheels, int steeringAngle)
        {
            Wheels = wheels;
            SteeringAngle = steeringAngle;
        }
        public override string ToString()//metoda mowi co napisac, gdy w cw wpiszemy "tractor" piszemy malo, klucz-wartosc
        {
            return $"Wheels: {Wheels}, SteeringAngle: {SteeringAngle}";
        }
    }
}

//POCO _ Plain Old CLR Object
//properties - dzialaja jak get/set
//w properties robimy walidering w set
//konstruktor zawsze public i nie ma returvärde nawet void
//w konstruktorze poslugujemy sie properties aby zachowac walidacje, dziala properties jak filtr
//potem overload konstruktor z jednym i potem z dwoma inparametrami
//nie mozemy overload konstruktora z int jako inparameter steeringAngle
//ostatnia metoda ToString - pisz wszystko jako string zamiast Forelasning_23_11.Tractor