using System;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hyra bil!");
            Console.WriteLine("Antal timmar du vill hyra en bil:");
            int timmar = int.Parse(Console.ReadLine());
            int total = timmar * 80;
            Console.WriteLine("Detta kommer att kosta " + total + " kr.");
        }
    }
}