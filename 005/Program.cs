using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, reverse = 0;

            Console.WriteLine("Enter a value: ");
            value = int.Parse(Console.ReadLine());

            while(value != 0) {
                reverse = reverse * 10;
                reverse = reverse + value % 10;
                value = value/10;
            }

            Console.WriteLine($"Reversed value: {reverse}");
        }
    }
}
