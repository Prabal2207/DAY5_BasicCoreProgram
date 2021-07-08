using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            OddEven();
        }
        public static void OddEven()
        {
            Console.WriteLine("Enter number 1:");
            int A = Convert.ToInt32(Console.ReadLine());
            if(A%2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
