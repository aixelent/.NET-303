using System;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("First value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second value: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            if(a >= 0 && b >= 0) {
                Console.WriteLine("Both values are positive");
            } 
            else {
                Console.WriteLine("One of values are negative");
            }
        }
    }
}
