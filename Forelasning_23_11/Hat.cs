using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Hat
    {
        byte size;
        string color;
        string hatType;

        public byte Size
        {
            get
            {
                return size;
            }

            set
            {
                var validValue = value != 0 && value >= 40 && value <= 60;
                if (validValue)
                    size = value;
                else
                    throw new Exception("Wrong value.");
            }
        }
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                var validValue = value != null;
                if (validValue)
                    color = value;
                else
                    throw new Exception("Wrong value.");
            }
        }
        public string HatType
        {
            get
            {
                return hatType;
            }

            set
            {
                var validValue = value != null;
                if (validValue)
                    hatType = value;
                else
                    throw new Exception("Wrong value.");
            }
        }

        public Hat()
        {
            Size = 52;
            Color = "black";
            HatType = "panama";
        }
        public Hat(byte size)
        {
            Size = size;
            Color = "brown";
            HatType = "panama";
        }
        public Hat(byte size, string color)
        {
            Size = size;
            Color = color;
            HatType = "panama";
        }
        public Hat(byte size = 52, string color = "black", string hatType = "panama")
        {
            Size = size;
            Color = color;
            HatType = hatType;
        }
        public override string ToString() => $"Size: {Size}, Color: {Color}, Hattype: {HatType}";
       
    }
}
//byxor, skor, varor