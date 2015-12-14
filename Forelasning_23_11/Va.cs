using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Va
    {
        string questionMark; 
        double inflection; 
//stor bokstav jako first ostatnie ?
        public string QuestionMark
        {
            get { return questionMark; }
            set
            {
                //att refaktorisera //ctrl rr zmienia nazwe metody wszedzie
                var firstCharIsUpperCase = value[0].ToString().ToUpper() == value[0].ToString();//måste toString för att det är char
                var endsWithQuestionMark = value.EndsWith("?");//eller value[value.Length - 1] == '?'
                var validValue = value != null && firstCharIsUpperCase && endsWithQuestionMark;
                if (validValue)
                    questionMark = value;
                else
                    throw new Exception("Wrong value.");
            }
        }
//3-17
        public double Inflection
        {
            get { return inflection; }
            set
            {
                var validValue = value >= 3.0 && value <= 17.0;
                if (validValue)
                    inflection = value;
                else
                    throw new Exception("Wrong value.");
            }
        }

        public Va()
        {
            QuestionMark = "Vad?";
            Inflection = 4.4;
        }
        public Va(string questionMark)
        {
            QuestionMark = questionMark;
            Inflection = 4.4;
        }
        public Va(double inflection)
        {
            QuestionMark = "Vad?";
            Inflection = inflection;
        }
        public Va(string questionMark, double inflection)
        {
            QuestionMark = questionMark;
            Inflection = inflection;
        }
        public override string ToString()
        {
            return $"Questionmark: {QuestionMark}, inflection: {Inflection}.";
        }

    }
}
