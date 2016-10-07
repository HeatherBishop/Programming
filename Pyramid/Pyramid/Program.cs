using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = 0;
            bool valid = false;

            while(!valid)
             {
               
                //get info from user about pyramid height
                Console.Write("Enter the pyramid height: ");
                //makes computer stop and wait for user to input. Stores that in string.
                string currentEntry = Console.ReadLine();   
                //conversion of string to int
                //tri-pass
                valid = Int32.TryParse(currentEntry, out height);

                if (height <= 0 || height > 23)
                    valid = false;
            }

            //print pyramid of hashs to screen
            //must be justified to right
            //width is height+1 at any time

            int hashCount = 2;

            //i = 0 is start condition
            //running condition i < height
            
            for (int i = 0; i < height; i++)
            {
                //build and print line to console
                //use string to display hashtags
                string line = " ";
                //justfy to right
                //height - hash count + 1
                int spaces = height - hashCount + 1;
                //build strings
                for (int j = 0; j < spaces; j++)
                {
                    //use catcatination
                    line += " ";
                }

                //build hash symbols
                for (int j = 0; j < hashCount; j++)
                {
                    line += "#";
                }

                //print line out
                Console.WriteLine(line);
                hashCount++;
            }
                      

            Console.ReadLine(); 
        }
    }
}
