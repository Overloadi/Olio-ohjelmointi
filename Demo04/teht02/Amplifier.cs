using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Amplifier
    {
        private int currentvolume = 0;
        public int CurrentVolume
        {
            get
            {
                return currentvolume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    currentvolume = value;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Volume set too low, volume set to 0");
                    currentvolume = 0;
                }
                else
                {
                    Console.WriteLine("Volume set too high, volume set to 100");
                    currentvolume = 100;
                }
            }
        }
    }
}
