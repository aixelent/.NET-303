using System;

namespace _024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string: ");
            string input = Console.ReadLine();

            if(input.Contains("Bulbasaur")) {
                Console.WriteLine("Great! Bulbasaur is here o/");
            }
            else {
                Console.WriteLine("Not found");
            }
        }
    }
}
