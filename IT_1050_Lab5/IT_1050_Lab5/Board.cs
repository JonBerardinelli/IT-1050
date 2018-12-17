using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class Board
    {
        public const int size = 8;
        public static string[][] grid; 

        public void CreateBoard()
        {
            Console.Clear();
            grid = new string[size][];

            for (int i = 0; i < size; i++)
            {
                grid[i] = new string[size];

                for (int j = 0; j < size; j++)
                {
                    grid[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

        public void PrintBoard()
        {
            //Writes top line of grid numbers
            int rowlength = grid.GetLength(0);
            System.Console.Write("    ");
            for (int i = 0; i< rowlength; i++)
            {
//                System.Console.Write(" ");
                System.Console.Write(" " + i + " |");
            }
            System.Console.WriteLine("");
            System.Console.Write("  ----------------------------------");

            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine();
                System.Console.Write("  "+i); // x axis header
/*                for (int j = 0; j < rowlength; j++)
                {
                    Console.Write("_");
                }
*/
                for (int j = 0; j < size; j++)
                {
                    System.Console.Write("| " +grid[i][j] + " ");
                }
                System.Console.WriteLine("|");
                System.Console.Write("  ----------------------------------");
                

            }
        }


    }
}
