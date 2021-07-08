using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            nthHarmonic();
        }

       
       public static void nthHarmonic()
        {
            Console.WriteLine("Enter N");
            int n=Convert.ToInt32(Console.ReadLine());
            float harmonic = 1;

            for (int i = 2; i <= n; i++)
            {
                harmonic += (float)1 / i;
            }

            Console.WriteLine("Nth Harmonic Value is : " + harmonic);
        }
    }
}
