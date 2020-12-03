using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollercoasterApp
{
    class Train
    {
        public List<Carriage> Carriages = new List<Carriage>();
        bool stationary;

        public Train(int numberOfCarriages)
        {
            stationary = true;

            for (int i = 0; i < numberOfCarriages; i++)
            {
                Carriages.Add(new Carriage());
            }
        }

        public void Arrive()
        {
            stationary = true;

            foreach (Carriage carriage in Carriages)
            {
                carriage.IsOccupied = false;
            }
        }

        public void Depart()
        {
            stationary = false;
        }

        public int CalculateTotalOccupancies()
        {
            int sum = 0;
            foreach (Carriage carriage in Carriages)
            {
                sum += carriage.NumberOfTimesOccupied;
            }

            return sum;
        }

    }
}
