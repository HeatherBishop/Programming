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

            //user input
            double coinage = 0;
           // decimal coins;
            bool valid = true;

            //coin denominations
            double fifty = 0.50;
            double twenty = 0.20;
            double ten = 0.10;
            double five = 0.05;
            double two = 0.02;
            double one = 0.01;

            //number of required coins
            int no50s = 0;
            int no20s = 0;
            int no10s = 0;
            int no5s = 0;
            int no2s = 0;
            int no1s = 0;




            while (valid)
            {
                Console.Write("How much change is required?");

                string currentEntry = Console.ReadLine();
                // convert string to double                
              if(Double.TryParse(currentEntry, out coinage))
                valid = false;

            }

        


            while (coinage >= fifty)
                {
                    coinage -= fifty;
                    no50s++;                
            }
                while (coinage >= twenty)
                {
                    coinage -= twenty;
                    no20s++;
                }
                while (coinage >= ten)
                {
                    coinage -= ten;
                    no10s++;
                }


                while (coinage >= five)
                {
                    coinage -= five;
                    no5s++;
                }


                while (coinage >= two)
                {
                    coinage -= two;
                    no2s++;
                }

                while (coinage >= one)
                {
                    coinage -= one;
                    no1s++;

                }
                if (coinage <= 0)
                {
                    coinage = 0;
                    valid = true;
                }





            Console.WriteLine("Number of 50ps: "+ no50s);
            Console.WriteLine("Number of 20ps: "+ no20s);
            Console.WriteLine("Number of 10ps: "+ no10s);
            Console.WriteLine("Number of 5ps: "+ no5s);
            Console.WriteLine("Number of 2ps: "+ no2s);
            Console.WriteLine("Number of 1ps: "+ no1s);


            
            Console.ReadLine();

        }


        
       
    }
    
}
