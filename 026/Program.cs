using System;

namespace _026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            int inputValue = Convert.ToInt32(Console.ReadLine());

            if(inputValue > 0) {
                if(inputValue % 3 == 0 || inputValue % 5 == 0) {
                    Console.WriteLine("Value {0} is multiple by 3 or 5", inputValue);
                }
                else {
                    Console.WriteLine("{0} is not a multiple.", inputValue);
                }
            }
        }
    }
}
