using System;
using System.Linq;

namespace _20._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse string: ");
            string s = Console.ReadLine();
            string[] str = s.Split("");

            foreach(String st in str.Reverse()) {
                Console.Write(s + "");
            }


            // string s;
            // Console.WriteLine("Reverse string; ");
            // s = Console.ReadLine();

            // Console.WriteLine("Reversed: " + String.Join("", s.Split("").Reverse()));           
        }
    }
}
