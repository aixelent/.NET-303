using System;

namespace _018
{
    class Program
    {
        static void Main(string[] args)
        {
            int dig = 0;
            int n = 2;
            int sum = 0;

            while(dig < 100) {
                if(isNumberPrime(n)) {
                    sum += n;
                    dig++;
                }
                n++;
            }
            Console.WriteLine("Sum for the first 100 digits: " + sum.ToString());
        }

        public static bool isNumberPrime(int n) {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if(n == 1) 
                return false;
            if(n == 2)
                return true;
            
            for(int i = 2; i <= x; ++i) {
                if(n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
