using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{

    //insertion sort maintains a sorted sublist in the
    //lower positions of the list
    //each new item is inserted back into the previous sublist
    //this way the sorted sublist is one index larger

//pseudo code
// 1.FOR j ← 2 TO length[A]
//2.DO key ← A[j] 
//3.{Put A[j] into the sorted sequence A[1. .j − 1] 
//4.i ← j − 1 
//5.WHILE i > 0 and A[i] > key
//6.DO A[i + 1] ← A[i] 
//7.i ← i − 1 
//8.A[i + 1] ← key

    class Program
    {
        static int InsertionSorting()

        {

            Console.Write("\nSorting a numeric array using Insertion Sorting");

            Console.Write("\n\nEnter how many numbers to sort: ");

            int max = Convert.ToInt32(Console.ReadLine());
            int[] numarray = new int[max]; //using user input to populate array
            for (int i = 0; i < max; i++) //if the array has more less values than user input

            {

                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());

            }



            Console.Write("Input int array  : ");

            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");

            Console.Write("\n");



            for (int i = 1; i < max; i++)

            {
                int j = i;
                while (j > 0)
                {
                    if (numarray[j - 1] > numarray[j])
                    {
                        int temp = numarray[j - 1];
                        numarray[j - 1] = numarray[j];
                        numarray[j] = temp;
                        j--;

                    }

                    else
                        break;

                }

                Console.Write("Iteration " + i.ToString() + ": ");

                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");

                Console.Write("\n");

                 

            }



            Console.Write("\n\nThe numbers in ascending orders are:\n\n");

            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");

            }

            return 0;

        }

        static void Main(string[] args)

        {
            InsertionSorting();
            Console.ReadLine();
        }

    }
}
