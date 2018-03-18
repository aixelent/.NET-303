using System;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random static generator: ");
            RandomStat();
            Console.WriteLine("And again for other result: ");
            RandomStat();
        }

        static Random _random = new Random();
        static void RandomStat() 
        {
            int num = _random.Next();
            Console.WriteLine(num);
        }
    }
}
