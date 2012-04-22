using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeral
{
    public class RomanNumerial
    {

        public RomanNumerial(String romanNumerial)
        {
            this.RomanNumber = romanNumerial;
        }

        public RomanNumerial(int arabicNumber)
        {
            // TODO: Complete member initialization
            this.ArabicNumber = arabicNumber;
        }

        public void Convert()
        {
            
        }

        public int ArabicNumber { get; set; }

        public string RomanNumber { get; set; }

        public object ToInt()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
