using System;

namespace Largestamong3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            largest();
        }
        public static void largest()
        {
            Console.WriteLine("Enter number 1:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int C = Convert.ToInt32(Console.ReadLine());
            int largest = A > B ? (A > C ? A : C) : (B > C ? B : C);
            Console.WriteLine("Largest number is" + largest);
        }
    }
}