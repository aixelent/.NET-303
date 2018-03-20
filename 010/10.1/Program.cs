using System;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime(2017, 3, 20);
            Console.WriteLine("First date: {0}", firstDate);

            DateTime secondDate = new DateTime(2018, 5, 15);
            Console.WriteLine("Second date: {0}", secondDate);

            if(firstDate < secondDate) {
                Console.WriteLine("{0} is earlier than {1}", firstDate, secondDate);
            }
            else {
                Console.WriteLine("{0} is after {1}", firstDate, secondDate);
            }
        }
    }
}
