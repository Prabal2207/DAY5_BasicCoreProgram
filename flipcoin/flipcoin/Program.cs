using System;

namespace flipcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip Coin");
            Flip();
        }

        public static void Flip()
        {
            
            int count1 = 0;
            int count2 = 0;
            
            Console.WriteLine("Number of times to Flip coin");
            int num= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Random random = new Random();
                double result = random.NextDouble();
                if (result < 0.5)
                {
                    Console.WriteLine("tails");
                    count1++;
                }
                else
                {
                    Console.WriteLine("heads");
                    count2++;
                }
            }

            double PercentageofTail = (int)Math.Round((double)(100 * count1) / num);
            double PercentageofHead = (int)Math.Round((double)(100 * count2) / num);



           Console.WriteLine("Percentage of tails=" + PercentageofTail);
           Console.WriteLine("Percentage of Heads=" + PercentageofHead);




        }
    }
}
