using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class PlacePiece
    {
        
        public void CreateChessSets()
        {
            for (int i = 0; i < Board.size; i++)
            {
                Board.grid[i] = new string[Board.size];

                for (int j = 0; j < Board.size; j++)
                {
                    Board.grid[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

    }
}
