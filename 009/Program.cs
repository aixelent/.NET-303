using System;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 3, 20);

            Console.WriteLine(dateTime.ToString("yyyy-MM-dd"));
            Console.WriteLine(dateTime.ToString("yy-MM-dd"));
            Console.WriteLine(dateTime.ToString("yy-M-d"));
            Console.WriteLine(dateTime.ToString("yy-dd-MM"));
            Console.WriteLine(dateTime.ToString("MM-dd-yyyy"));
            Console.WriteLine(dateTime.ToString("MM-dd-yy"));
            Console.WriteLine(dateTime.ToString("M-d-yyyy"));
            Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
            Console.WriteLine(dateTime.ToString("d-MM-yy"));
        }
    }
}
