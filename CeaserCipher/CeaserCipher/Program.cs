using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    class Program
    {
        class MainClass
        {
            public static void Main()
            {
                string UserString = null;
                int shift;
                Shift OBSHIFT = new Shift();
                Console.WriteLine("Ceasar Shift Program:");
                Console.WriteLine("********************************");

                Console.WriteLine("What do you want to encrypt?:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                UserString = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;



                Console.WriteLine("What is the shift value?: :");
                Console.ForegroundColor = ConsoleColor.Yellow;
                shift = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("Your encrypted string is: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(OBSHIFT.Cshift(UserString, shift));
                Console.Read();
            }
        }

        class Shift
        {
            public string Cshift(string str, int shift)
            {
                string UserOutput = null; // no user input
                char[] A = null;
                A = str.ToCharArray();
                int temp;

                for (int i = 0; i < str.Length; i++) // for each index in str array
                {
                    temp = (int)(A[i] + shift); //temporary variable to add shift value to index plaxes
                    UserOutput += (char)temp; // user output add temp variable.
                }
                return UserOutput;
            }
        }

    }
}
