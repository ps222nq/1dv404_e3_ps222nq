using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Uppgift1
    {
        static void Main(string[] args)
        {
            NastStorsta();
            
        }


        static void RaknaSiffror()
        {
            int countZero = 0;
            int countOdd = 0;
            int countEven = 0;
            int input;
            string inputString = "";


            while (true)
            {
                try
                {
                    Console.WriteLine("Mata in ett tal");
                    input = int.Parse(Console.ReadLine());
                    inputString = input.ToString();

                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Något gick fel, vänligen mata in ett heltal");
                    Console.ResetColor();
                }

                foreach (char c in inputString)
                {
                    if (c == '0')
                    {
                        countZero++;
                    }
                    else if (c % 2 == 0 && c > 1)
                    {
                        countEven++;
                    }
                    else
                    {
                        countOdd++;
                    }
                }

                Console.WriteLine("Udda: {0} \nJämna: {1} \nNollor: {2}\n", countOdd, countEven, countZero);

                //reset for next try
                countZero = 0;
                countOdd = 0;
                countEven = 0;

            }
        }


        static void RaknaA() 
        {
            while (true)
            {
                Console.WriteLine("Mata in en sträng:");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vänligen mata in en sträng med minst 1 bokstav.");
                    Console.ResetColor();
                }
                else
                {
                    int countLowerA = 0;
                    int countUpperA = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'a') { countLowerA++; }
                        if (input[i] == 'A') { countUpperA++; }
                    }

                    Console.WriteLine("Antal a: {0} \nAntal A: {1} \n", countLowerA, countUpperA);
                }
            }
        }

        static void NastStorsta()
        {
            int countNumbers = 10;
            int input = 0;
            int highest = int.MinValue;
            int secondHighest = int.MinValue;
            int guessCount = 0;

            Console.WriteLine("Mata in {0} tal:", countNumbers);

            while (guessCount < countNumbers)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vänligen mata in ett heltal.");
                    Console.ResetColor();
                    guessCount--;
                }

                if (input > highest) 
                {
                    secondHighest = highest;
                    highest = input;
                    guessCount++;
                }
                else if (input > secondHighest)
                {
                    secondHighest = input;
                    guessCount++;
                }
                else if (input != null)
                {
                    guessCount++; 
                }

            }
            Console.WriteLine("Störst: {0}\nNäst störst: {1}\n", highest, secondHighest);
        }
        }
}
