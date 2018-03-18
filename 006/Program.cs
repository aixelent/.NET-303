using System;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Generating number from 0 to 100: " + random.Next(0, 100));
        }
    }
}
