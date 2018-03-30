using System;

namespace _023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary converter. Type a number: ");
            Console.WriteLine("Binary: " + Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2));
        }
    }
}
