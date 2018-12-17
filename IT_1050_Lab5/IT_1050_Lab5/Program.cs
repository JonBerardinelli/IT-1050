using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            MovePiece move = new MovePiece();
            PlacePiece newPiece = new PlacePiece();

            while (!(move.endCheck))
            {
                board.CreateBoard();
                board.PrintBoard();
                System.Console.WriteLine("");

                move.MakeMove();
            }
/*            System.Console.WriteLine("");
            System.Console.WriteLine("Press any button to end program");*/
            System.Console.ReadKey();
        }
    }
}
