using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class MovePiece
    {
        private int currentXPosition;
        private int currentYPosition;
        private int newXPosition;
        private int newYPosition;
        public bool endCheck { get; set; }

        public MovePiece()
        {
            currentXPosition = 0;
            currentYPosition = 0;
            newXPosition = 0;
            newYPosition = 0;
            endCheck = false;
        }

        public void MakeMove()
        {
            getCoordinates();

            if (!endCheck)
                changePiecePlacement();
        }

        private void getCoordinates()
        {
            Console.WriteLine("Enter Target's X axis");
            endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out currentXPosition));
            if (!endCheck) 
            {
                Console.WriteLine("Enter Target's Y axis");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out currentYPosition));
            }
            if (!endCheck) 
            {
                Console.WriteLine("Enter Destination's X axis");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out newXPosition));
            }
            if (!endCheck)
            {
                Console.WriteLine("Enter Destination's Y axis");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out newYPosition));
            }
        }

        private bool checkGridBoundry(bool parsed)
        {
            bool outOfBounds = false;

            if (!parsed)
                outOfBounds = true;
            else if (currentXPosition < 0 || currentYPosition < 0 || newXPosition < 0 || newYPosition < 0)
                outOfBounds = true;
            else if (currentXPosition > Board.size - 1 || currentYPosition > Board.size - 1 ||
                      newXPosition > Board.size - 1 || newYPosition > Board.size - 1)
                outOfBounds = true;

            if (outOfBounds)
                Console.WriteLine("The entered coordinates were out of the bounds of the grid." +
                    " Ending Program.");

            return outOfBounds;
        }

        private void changePiecePlacement()
        {
            PlacePiece.playingPieces[newXPosition, newYPosition] = PlacePiece.playingPieces[currentXPosition, currentYPosition]; 
            PlacePiece.playingPieces[currentXPosition, currentYPosition] = PlacePiece.spacer; 
        }

    }
}
