using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Elevator
    {
        private int currentfloor = 1;
        public int CurrentFloor
        {
        get
        {
            return currentfloor;
        }
        set
        {
            if (value >= 1 && value <= 5)
            {
                currentfloor = value;
            }
            else
            {
                Console.WriteLine("Please choose a floor number between 1 and 5");
            }
        }
    }

    }
}
