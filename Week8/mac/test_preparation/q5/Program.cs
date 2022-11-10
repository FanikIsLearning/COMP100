using System;

/*

 *     * 
  *   *  
   * *   
    *    
   * *   
  *   *  
 *     * 
*       *
       
*/

namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 9, ROWS = 9;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    if (row + col == 8 || row == col )
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
