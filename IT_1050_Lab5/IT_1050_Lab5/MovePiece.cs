using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab5
{
    public class MovePiece
    {
        private int currentYPosition;
        private int currentXPosition;
        private int newYPosition;
        private int newXPosition;
        public bool endCheck { get; set; }

        public MovePiece()
        {
            currentYPosition = 0;
            currentXPosition = 0;
            newYPosition = 0;
            newXPosition = 0;
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
            Console.WriteLine("All coordinates must be between 0-7");
            Console.WriteLine("Enter Target's X Coordinate: ");
            endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out currentYPosition));
            if (!endCheck) 
            {
                Console.WriteLine("Enter Target's Y Coordinate: ");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out currentXPosition));
            }
            if (!endCheck) 
            {
                Console.WriteLine("Enter Destination's X Coordinate: ");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out newYPosition));
            }
            if (!endCheck)
            {
                Console.WriteLine("Enter Destination's Y Coordinate: ");
                endCheck = checkGridBoundry(int.TryParse(Console.ReadLine(), out newXPosition));
            }
        }

        private bool checkGridBoundry(bool parsed)
        {
            bool outOfBounds = false;

            if (!parsed)
                outOfBounds = true;
            else if (currentYPosition < 0 || currentXPosition < 0 || newYPosition < 0 || newXPosition < 0)
                outOfBounds = true;
            else if (currentYPosition > Board.size - 1 || currentXPosition > Board.size - 1 ||
                      newYPosition > Board.size - 1 || newXPosition > Board.size - 1)
                outOfBounds = true;

            if (outOfBounds)
                Console.WriteLine("The entered coordinates were out of the bounds of the grid." +
                    " Ending Program.");

            return outOfBounds;
        }

        private void changePiecePlacement()
        {
            Board.grid[newXPosition][newYPosition] = Board.grid[currentXPosition][currentYPosition];
            Board.grid[currentXPosition][currentYPosition] = " ";
        }

    }
}
