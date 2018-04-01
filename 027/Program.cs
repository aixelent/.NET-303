using System;

namespace _027
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First second: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First third: ");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First fourth: ");
            int fourth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First fourth: ");
            
            Console.WriteLine("Largest value: " + Math.Max(first, Math.Max(second, Math.Max(third, fourth)))  + "\n" 
                + "Lowest value: " + Math.Min(first, Math.Min(second, Math.Min(third, fourth)))); 
        }
    }
}
