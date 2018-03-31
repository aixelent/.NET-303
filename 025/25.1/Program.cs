using System;

namespace _025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string: ");
            string inputValue = Console.ReadLine();
            Console.WriteLine(inputValue.StartsWith("Bulbasaur"));
        }
    }
}
