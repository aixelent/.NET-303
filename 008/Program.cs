using System;

namespace _008
{
    class Program
    {
        int year;
        public void getYear() {
            // int year;
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }
         
        public void isLeap() {
            if(year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0))) {
                Console.WriteLine("{0} is a leap year", year);
            }
            else {
                Console.WriteLine("{0} isn't a leap year", year);
            }
        }

        static void Main(string[] args)
        {
            Program leapYear = new Program();
            leapYear.getYear();
            leapYear.isLeap();
        }
    }
}
