using System;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Factors();

        }

        public static void Factors()
        {

            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    int count = 0;
                    for(int j=1;j<=i;j++)
                    { 
                        if(i%j == 0)
                        {
                            count++;
                        }
                        
                    }
                    if (count == 2)
                    {
                        Console.WriteLine(i + " is Prime Factor : " + number);
                    }
                }

            }
            
        }
    }
}
