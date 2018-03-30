using System;

namespace _022
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            Console.WriteLine("Hexadecimal to decimal converter. Type a number: ");
            inputValue = Convert.ToString(Console.ReadLine());
            int decimalValue = int.Parse(inputValue, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal: " + decimalValue);
        }
    }
}
