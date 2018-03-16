using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue, swapper;
            Console.Write("First value:");
            firstValue = int.Parse(Console.ReadLine());
            
            Console.Write("Second value:");
            secondValue = int.Parse(Console.ReadLine());
            
            swapper = firstValue;
            firstValue = secondValue;
            secondValue = swapper;

            Console.Write("After swapping two values:");
            Console.Write($"\nFirst value: {firstValue}. Second value: {secondValue}\n");
        }
    }
}
