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
        public static string[][] grid = new string[size][];
        MovePiece move = new MovePiece();
        PlacePiece newSet = new PlacePiece();

        public void ChessBoard()
        {
            newSet.CreateChessSets();
            while (!(move.endCheck))
            {
                Console.Clear();
                int rowlength = grid.GetLength(0);
                System.Console.Write("    ");
                for (int i = 0; i < rowlength; i++)
                {
                    System.Console.Write(" " + i + " |");
                }
                System.Console.WriteLine("");
                System.Console.Write("  ----------------------------------");

                for (int i = 0; i < size; i++)
                {
                    System.Console.WriteLine();
                    System.Console.Write("  " + i); 
                    for (int j = 0; j < size; j++)
                    {
                        System.Console.Write("| " + grid[i][j] + " ");
                    }
                    System.Console.WriteLine("|");
                    System.Console.Write("  ----------------------------------");
                }
                System.Console.WriteLine("");
                move.MakeMove();
            }
        }
    }
}
