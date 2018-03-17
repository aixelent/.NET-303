using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue;
            
            Console.Write("First value: ");
            firstValue = int.Parse(Console.ReadLine());
            Console.Write("Second value: ");
            secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: {firstValue}, {secondValue}");

            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue;
            firstValue = firstValue - secondValue;

            Console.WriteLine($"After: {firstValue}, {secondValue}");
        }
    }
}
