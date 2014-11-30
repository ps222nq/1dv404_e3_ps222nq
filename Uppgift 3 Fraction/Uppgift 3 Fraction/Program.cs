using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(1,4);
            Fraction frac2 = new Fraction(2,8);

            //Test 1: IsEqual()
            Console.WriteLine("Test 1: Att jämföra 2 bråk med IsEqual():");
            Console.WriteLine("Är " + frac1.ToString() + " samma som " + frac2.ToString() + "?");
            Console.WriteLine(frac1.IsEqual(frac1, frac2));
            Console.WriteLine();

            //Test 2: IsNegative()
            Console.WriteLine("Test 2: Att kontrollera för negativa tal med IsNegative():");
            Console.WriteLine("Är " + frac1.ToString() + " negativ?");
            Console.WriteLine(frac1.IsNegative(frac1));
            Console.WriteLine();
            
            //Test 3: ToString()
            Console.WriteLine("Test 3: skriva ut bråktal som sträng med ToString()");
            Console.WriteLine("Bråktalet frac1: " + frac1.ToString());
            Console.WriteLine("Bråktalet frac2: " + frac2.ToString());
            Console.WriteLine();

            //Test 4: Add()
            Console.WriteLine("Test 4: addition av bråktal med Add()");
            Fraction frac3 = Fraction.Add(frac1, frac2);
            Console.WriteLine(frac1.ToString() + " + " + frac2.ToString() + " = " + frac3.ToString());
            Console.WriteLine();

            //Test 5: Multiply()
            Console.WriteLine("Test 5: multiplikation av bråktal med Multiply()");
            Fraction frac4 = Fraction.Multiply(frac1, frac3);
            Console.WriteLine(frac1.ToString() + " * " + frac2.ToString() + " = " + frac4.ToString());
            Console.WriteLine();
        }
    }
}
