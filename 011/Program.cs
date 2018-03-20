using System;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int fValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second value: ");
            int sValue = Convert.ToInt32(Console.ReadLine());

            //Add
            Console.WriteLine("{0} + {1} = {2}", fValue, sValue, fValue + sValue);
            //Substract
            Console.WriteLine("{0} - {1} = {2}", fValue, sValue, fValue - sValue);
            //Multiply
            Console.WriteLine("{0} * {1} = {2}", fValue, sValue, (fValue * sValue));
            //Divide
            Console.WriteLine("{0} / {1} = {2}", fValue, sValue, (fValue / sValue));
        }
    }
}
