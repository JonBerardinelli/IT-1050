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
            PlacePiece newPiece = new PlacePiece();

            board.ChessBoard();
            System.Console.WriteLine("");
            
            System.Console.ReadKey();
        }
    }
}
