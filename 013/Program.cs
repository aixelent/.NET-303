using System;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            Console.WriteLine("Type keyword: ");
            inp = Convert.ToString(Console.ReadLine());

            for(int i = 0; i < inp.Length; i++) {
                Console.Write(inp[inp.Length - i - 1]);
            }
            Console.WriteLine();
        }
    }
}
