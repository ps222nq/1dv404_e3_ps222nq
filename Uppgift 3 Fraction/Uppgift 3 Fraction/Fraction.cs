using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_Fraction
{
    class Fraction
    {
        private int _denominator;

        public int Numerator {
            get; 
            set;
        }

        public int Denominator {
            get 
            {
                return _denominator; 
            }
            set
            {
                if(value != 0){
                    _denominator = value;
                }
                else
                {
                    throw new FormatException ("An error occurred. Denominator can not be 0.");
                }
            }
        }

        public Fraction(int num, int den) {
            Numerator = num;
            Denominator = den;
        }

        public bool IsNegative(Fraction f)
        {
            if(Numerator < 0 || Denominator < 0){
                return true;
            }
            else {
                return false; 
            }
        }

        public bool IsEqual(Fraction fOne, Fraction fTwo)
        {
            if (fOne.Numerator / fOne.Denominator == fTwo.Numerator / fTwo.Denominator) {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Fraction Add(Fraction fOne, Fraction fTwo) 
        {
            int resultNum;
            int resultDen;

            if (fOne.Denominator == fTwo.Denominator)
            {
                resultNum = fOne.Numerator + fTwo.Denominator;
                resultDen = fOne.Numerator;
            }
            else
            {
                resultNum = (fOne.Numerator * fTwo.Denominator) + (fTwo.Numerator * fOne.Denominator);
                resultDen = fOne.Denominator * fTwo.Denominator;
            }

            return new Fraction(resultNum, resultDen);
        
        }

        public static Fraction Multiply(Fraction fOne, Fraction fTwo)
        {
            int resultNum = fOne.Numerator * fTwo.Denominator;
            int resultDen = fOne.Denominator * fTwo.Denominator;

            return new Fraction(resultNum, resultDen);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
    }
}
