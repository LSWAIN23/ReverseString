using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a console app that takes a users input as a string and outputs the same string in reverse.

namespace ReverseString
{
    class Program
    {
        static string reverseString(string input)
        {
            char[] letters = input.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentance");
            Console.WriteLine("----------------------------------------");
            string input = Console.ReadLine();
            Console.WriteLine("The reverse of your sentance is: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(reverseString(input));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Now can you enter a sentance backwards and have it print correctly? Try it out");
            Console.WriteLine("----------------------------------------");
            string backward = Console.ReadLine();
            Console.WriteLine("The reverse of your sentance is: ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(reverseString(backward));
        }
    }
}
