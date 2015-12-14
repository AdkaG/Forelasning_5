using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Game//Backingfield
    {
        private int lives;
        private string name;

        public string Name //zawsze publiczne
        {
            get
            {
                return name;
            }
            set
            {
                if(value !=null)
                name = value;
            }
        }


        public int Lives//PascalCase
        {
            get
            {
                return lives;
            }
            set
            {
                if(value >= 0)//kan sätta villkor
                lives = value;//value är istället för inparameter
            }
        }
    }
}
