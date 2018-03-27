using System;

namespace _016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers from 0 to 999:");

            for(int i = 0; i <= 999; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
