using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Find();
        }
        public static void Find()
        {
            int quotient, remainder;
            Console.WriteLine("Enter number 1:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int B = Convert.ToInt32(Console.ReadLine());
            quotient = A / B;

            remainder = A % B;

            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is" + remainder);
        }
    }
}
