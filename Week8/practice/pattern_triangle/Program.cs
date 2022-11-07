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
            for (int i = 1; i < 16; i +=2 )
            {
                for (int k = 0; k < (10 - i/2); k++)
                {
                    /* spacing */
                    Console.Write(" ");
                }
                for (int j = 0; j<i; j++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
