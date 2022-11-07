using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *           *
  *         *
   *       *
    *     *
     *   *
       *

 */

namespace pattern_Vshape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 20, ROWS = 5;
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row == col || row + col == 8)
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
