using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollercoasterApp
{
    class Carriage
    {
        bool isOccupied;
        int numberOfTimesOccupied;

        public bool IsOccupied
        {
            set { isOccupied = value; }
            get { return isOccupied;  }
        }

        public int NumberOfTimesOccupied
        {
            get { return numberOfTimesOccupied; }
        }

        public Carriage()
        {
            isOccupied = false;
            numberOfTimesOccupied = 0;
        }

        void IncrementTimesOccupied()
        {
                numberOfTimesOccupied += 1;
        }

        public void ChangeOccupancy()
        {
            if (!isOccupied)
            {
                isOccupied = true;
                IncrementTimesOccupied();
            }
            else
            {
                isOccupied = false;
            }
        }

     

    }
}
