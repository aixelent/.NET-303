using System;

namespace _23._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hexadecimal to decimal converter. Type a number: ");
            int inputValue = int.Parse(Console.ReadLine());
            int binParse = int.Parse(Convert.ToString(inputValue, 2));
            Console.WriteLine("Binary: " + binParse);
        }
    }
}
