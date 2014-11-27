using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reversed = new String(inputArray);

            if (reversed == input) { Console.WriteLine( input + " är en palindrom!"); }
        }
    }
}
