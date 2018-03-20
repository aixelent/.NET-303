using System;

namespace _010._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fDate = new DateTime(3018, 03, 15);
            DateTime sDate = new DateTime(2017, 11, 10);
            int result = DateTime.Compare(fDate, sDate);

            if(result < 0) {
                Console.WriteLine("{0} earlier than {1}", fDate, sDate);
            }
            else if (result == 0) {
                Console.WriteLine("both dates are the same");
            }
            else {
                Console.WriteLine("{0} is later than {1}", fDate, sDate);
            }
        }
    }
}
