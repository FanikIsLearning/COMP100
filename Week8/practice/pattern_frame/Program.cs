using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 8, ROWS = 8;
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row == 0 || col == 0 || row == 7 || col == 7)
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
