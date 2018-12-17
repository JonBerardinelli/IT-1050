using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class PlacePiece
    {
        public const char piece = 'X';
        public const char spacer = ' ';
        public static char[,] playingPieces;

        public PlacePiece()
        {
            playingPieces = new char[Board.size, Board.size];
            createPiece();
        }
        private void createPiece()
        {
            for (int i = 0; i < Board.size; i++)
            {
                for (int j = 0; j < Board.size; j++)
                {
                    if (i == 0 || i == 1 || i == 6 || i == 7)
                        playingPieces[i, j] = piece;
                    else
                        playingPieces[i, j] = spacer;
                }
            }
        }

    }
}
