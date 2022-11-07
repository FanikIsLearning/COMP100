using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
      *
     *
    *
   *
  *
 *
*
 */

namespace pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 10, ROWS = 7;
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row + col == 9)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
