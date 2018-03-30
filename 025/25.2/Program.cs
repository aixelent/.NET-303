using System;

namespace _25._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string: ");
            string inputValue = Console.ReadLine();
            Console.WriteLine(inputValue.Substring(0) == "Bulbasaur");
        }
    }
}
