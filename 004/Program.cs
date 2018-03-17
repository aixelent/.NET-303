using System;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, rev, sum = 0;

            Console.WriteLine("Enter a value: ");
            value = int.Parse(Console.ReadLine());

            while(value != 0) {
                rev = value % 10;
                value = value / 10;
                sum = sum + rev;
            }

            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
