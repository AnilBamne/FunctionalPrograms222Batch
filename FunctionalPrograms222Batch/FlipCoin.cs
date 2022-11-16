using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms222Batch
{
    public class FlipCoin
    {
        public void FlipTheCoin()
        {
            //Variables
            double HeadCount = 0;
            double TailCount = 0;
            double HeadPercentage = 0;
            double TailPercentage = 0;
            //Taking user input 
            Console.WriteLine("How many times you want to flip the coin");
            int t=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            //computation
            for (int i = 1; i <= t; i++)
            {
                double option = random.Next(0,2);
                if (option < 0.5)
                {
                    Console.WriteLine("Tails");
                    TailCount++;
                }
                else
                {
                    Console.WriteLine("Heads");
                    HeadCount++;
                }
            }
            //computing percentage
            HeadPercentage=(HeadCount*100)/t;
            TailPercentage=(TailCount*100)/t;
            Console.WriteLine("Percentage of Heads : "+HeadPercentage+"%");
            Console.WriteLine("Percentage of Tails : "+TailPercentage+"%");
        }
    }
}
