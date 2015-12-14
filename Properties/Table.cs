using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Table
    {
        string color;
        int numberOfChairs;

        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public int GetNumberOfChairs()
        {
            return numberOfChairs;
        }
        public void SetNumberOfChairs(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
        }
        

        public string Color
        {
            get { return color; }
            set
            {
                if(value != null)
                color = value;
            }
        }
        public int NumberOfChairs
        {
            get { return numberOfChairs; }
            set
            {
                if(value != 0)
                numberOfChairs = value;
            }
        }

        public Table(string color = "", int numberOfChairs = 0)
        {
            this.color = color;
            this.numberOfChairs = numberOfChairs;
        }

    }
}
