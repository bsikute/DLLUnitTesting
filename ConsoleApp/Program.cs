using System;
using ConsoleUtilities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            string stringOutput = "Hello World";
            utilities.WriteLine(stringOutput);
            Console.ReadKey();
        }
    }
}
