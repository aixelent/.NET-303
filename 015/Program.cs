using System;

namespace _015
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

            if(a == b) {
                Console.WriteLine("(({0} + {1}) * 9) = {2}", a, b, ((a + b) * 9));
            }
            else {
                Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            }
        }
    }
}
