using System;

namespace _017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers from 0 to 999:");

            for(int i = 0; i <= 999; i++) {
                if(i % 2 != 1) {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
