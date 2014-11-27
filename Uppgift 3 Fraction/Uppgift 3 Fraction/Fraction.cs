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

        public bool IsNegative()
        {

        }

        public bool IsEqual()
        {

        }

        public static Fraction Add() 
        {
        
        }

        public static Fraction Multiply()
        {

        }
    }
}
