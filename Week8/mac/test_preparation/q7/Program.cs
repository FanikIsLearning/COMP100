using System;

namespace q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 7, ROWS = 7;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row + col == 7)
                    {
                        Console.Write($" ");
                    }
                    else
                    {
                        Console.Write($"*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
