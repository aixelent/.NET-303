using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("Enter number: ");
            value = int.Parse(Console.ReadLine());

            if(value % 2 == 0) {
                Console.WriteLine("Value is even.");
            }
            else {
                Console.WriteLine("Value is odd.");
            }
        }
    }
}
