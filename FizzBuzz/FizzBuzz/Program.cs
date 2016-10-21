using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
  /*  class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <(1+ 100); i++)
            {
                if (i % 3 == 0 && i % 5 == 0) // if i is divisable by 3, and 5
                    Console.WriteLine("FizzBuzz"); // write fizzbuzz
                else if (i % 3 == 0) //if i is divisible by 3 == 0
                    Console.WriteLine("Fizz"); //write fizz
                else if (i % 5 == 0) // if i is divisible by 5 ==0
                    Console.WriteLine("Buzz"); //write buzz
                else
                    Console.WriteLine(i); // otherwise print i(1 + 100).
            }
            Console.Read();
            
        }
    }*/

    class ChrisFizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                //minimise no of if statements
                //remove else
                //build string
                string output = null;
                //to avoid chaning things together

                if (i % 3 == 0)
                    output = "Fizz";
                if (i % 5 == 0)
                    output += "Buzz"; // adding buzz to output instead of its own output.

                Console.WriteLine(output != null ? output : i.ToString()); //first part = question, fter ? must have true/false response
                                                    // after ? if null print output if not print i
                                                    //ternery operator - one line if statemtnt
                                                    //can be a sin if strining to many together

            }
            Console.ReadLine();
        }
    }
}
