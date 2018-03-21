using System;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            int fVal, sVal, tVal, result; 

            Console.WriteLine("Enter first value: ");
            fVal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second value: ");
            sVal = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter third value: ");
            tVal = Convert.ToInt32(Console.ReadLine());

            result = (fVal + sVal + tVal) / 3;
            Console.WriteLine("Average of {0}, {1}, {2} is: {3}", fVal + sVal + tVal, result);
        }
    }
}
