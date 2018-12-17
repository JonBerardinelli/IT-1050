using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates first instance of an elevator with passengers
            Elevator elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);

            //Check to see if the elevator1 is over weight capacity 
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            //Creates second instance of an elevator with passengers
            Elevator elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);

            //Check to see if the elevator2 is over weight capacity 
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}
