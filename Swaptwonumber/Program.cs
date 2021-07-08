using System;

namespace Swaptwonumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapTwoNumber();
        }

        public static void SwapTwoNumber()
        {
            int temp;
            Console.WriteLine("Enter number 1:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            int B = Convert.ToInt32(Console.ReadLine());
            temp = A;
            A = B;
            B = temp;

           

            

            Console.WriteLine("number 1 is " + A);
            Console.WriteLine("number 2 is" + B);
        }
    }
}
