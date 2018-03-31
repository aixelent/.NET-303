using System;
using System.IO;

namespace _021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of the file: ");
            FileInfo fSize = new FileInfo("C:/Windows/explorer.exe");
            
            Console.WriteLine(fSize.Length.ToString() + " bytes.");
            Console.WriteLine((fSize.Length / 1000F).ToString() + " kilobytes.");
            Console.WriteLine((fSize.Length / 1000000F).ToString() + " megabytes."); 
        }
    }
}
