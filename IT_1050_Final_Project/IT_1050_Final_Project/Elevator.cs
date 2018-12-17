using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Final_Project
{
    public class Elevator
    {
        private double MaxWeight { get; set; }
        private Passenger[] Occupants;

        public double sum { get; set; }

        public Elevator( int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant( Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            for (int i = 0; i < Occupants.Length; i++)
            {
                sum += Occupants[i].GetWeight();
            }    
            return sum;
        }
        public bool IsOverMaxCapacity()
        {
            bool OverCapacity = false;

            if (GetCurrentWeight() > MaxWeight)
            {
                OverCapacity = true;
            }

            return OverCapacity;
        }

    }
}
