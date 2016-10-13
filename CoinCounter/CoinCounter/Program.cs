using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCounter
{
    class Program
    {
        static void Main()
        {
            List<int> coins = new List<int>();
            List<int> demoninations = new List<int>() { 1, 2, 5, 10, 20, 50 };

            int coinage = 0;
            bool valid = false;



            while(!valid)
            {            
                //work out change for 27
                Console.Write("How much change is required?");
                Console.ReadLine();            

                string numCoins = Console.ReadLine();
                //convert string to int
                valid = Int32.TryParse(numCoins, out coinage);
            Change(coins, demoninations, 0, 0, coinage);
            }


        }
        static void Change(List<int> coins, List<int> denominations, int highest, int sum, int goal)
        {
            //have we reached the goal(set by user)
            if (sum == goal)
            {
                Display(coins, denominations);
                return;
            }

            //is there too much?
            if (sum > goal)
            {
                return;
            }

            //loop through denominations

            foreach (int value in denominations)
            {
                //only add higher or equal denominations
                if (value >= highest)
                {
                    List<int> copy = new List<int>(coins);
                    copy.Add(value);
                    Change(copy, denominations, value, sum + value, goal);
                }
            }
        }

        static void Display(List<int> coins, List<int> denominations)
        {
            foreach (int denomination in denominations)
            {
                int count = coins.Count(value => value == denomination);
                Console.WriteLine("{0}: {1}", 
                    denomination, 
                    count);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
       
    }
    
}
