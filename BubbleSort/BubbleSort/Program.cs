using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randomValues = new int[10];
            int tempVal = 0;

            Console.WriteLine("These are the random values.");
            for (int i = 0; i < 10; i++)
            {
                randomValues[i] = rand.Next(1, 51);//generate random values, store in array                
                Console.WriteLine(randomValues[i]);
                
            }
            
            Console.Write("These are the sorted random values.");
              for (int write = 0; write < randomValues.Length; write++) //if int(write) is greater than randomValues, add to write
               {
                   for (int sort = 0; sort < randomValues.Length - 1; sort++) //if int(sort) is greater than randomValues - 1, then add to sort.
                   {
                       if (randomValues[sort] > randomValues[sort + 1]) //if randomValues[sort as comparison] less than randomValues[sort + 1 as comparison]
                       {
                           tempVal = randomValues[sort + 1]; // assign randomValues[sort + 1 comparison] to tempVal
                           randomValues[sort + 1] = randomValues[sort]; // add sorted value [sort+1] to sort int.
                           randomValues[sort] = tempVal; //assign sort to be the tempValue
                       }
                   }
                   
                   
               }
            for (int i = 0; i < randomValues.Length; i++) //for each randomvalue add to i array
            Console.Write(randomValues[i] + " "); //write values to console
            Console.Read();


        }


    }
}
