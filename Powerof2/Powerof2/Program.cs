using System;

namespace Powerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            Powerof2();
        }

        public static void Powerof2()
        {
            int i = 0;

            Console.WriteLine("Enter n");
            double number = Convert.ToInt32(Console.ReadLine());
            double pow = Math.Pow(2, number);

            if (number >= 0 && number < 31)

            { 
                for (i = 1; i < number; i++)
                {
                    int result = 2 * i;
                    Console.WriteLine("table of 2 at " + i);
                    Console.WriteLine(result);
                    if (result == pow)
                    {
                        break;
                    }

                }


            }
            else
            {
                Console.WriteLine("Limit exceded");
            }
        }
    }
}
