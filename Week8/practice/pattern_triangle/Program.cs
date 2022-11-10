using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       *
      ***
     *****
    *******
   *********
  ***********
 *************
***************

creating a triangle for loops
 */

namespace pattern_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i < 16; i +=2 )
            {
                for (int k = 0; k < (10 - i/2); k++)
                {

                    Console.Write(" ");
                }
                for (int j = 0; j<i; j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }*/

            int a, b, count = 1, number;
          
            number = 8;
            count = number - 1;
            for (b = 1; b <= number; b++)
            {
                for (a = 1; a <= count; a++)
                    Console.Write(" ");
                count--;
                /*Right Triangle*/
                for (a = 1; a <= 2 * b - 1; a++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
