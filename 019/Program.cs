using System;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a value:");
            int n = Convert.ToInt32(Console.ReadLine());

            while(n != 0) {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
