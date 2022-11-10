using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_parallelogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 5, ROWS = 7;
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row == col)
                    {
                        for (int i = 0; i < 7; i++)
                        { 
                            Console.Write($"*"); 
                        }
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
