using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSort
{
    //selection sort starts at begginning of array[0]
    //travels the entire array comparing each value with currentValue
    //if its smaller, then that index is saved
    //once has gone over all data, if smaller value than current is found
    //swap them over.
    //current index is the incrimented, now to index[1]
    //repeat.
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randomValues = new int[10];

            for (int i = 0; i < 10; i++)
            {
                randomValues[i] = rand.Next(1, 51);
                Console.WriteLine(randomValues[i]);
            }

            //pos_Min = position of minValue
            int pos_min, temp;

            for (int i = 0; i < randomValues.Length - 1; i++)
            {
                pos_min = i; // set pos_min to the current index
                for (int j = i + 1; j < randomValues.Length; j++)
                {
                    if (randomValues[j] < randomValues[pos_min])
                    {
                        //pos_min keeps track of index that min is in
                        //important for when swapped
                        pos_min = j;
                    }
                }
                //if pos_min != i, then a smaller value has been found
                //swap

                if (pos_min != i)
                {
                    temp = randomValues[i];
                    randomValues[i] = randomValues[pos_min];
                    randomValues[pos_min] = temp;
                }
                Console.WriteLine("Sorted Values are:" + randomValues[i].ToString());
            }
           
            Console.Read();

        }
    }
}
