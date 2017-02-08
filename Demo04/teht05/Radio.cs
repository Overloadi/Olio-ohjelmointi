using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Radio
    {
        public bool IsOn;
        public int Volume;
        public double Freq;

        public void powerSwitch(bool set)
        {
            IsOn = set;
        }

        public void setVolume(int newvolume)
        {
            if (newvolume < 0)
            {
                Volume = 0;
            }
            else if (newvolume > 9)
            {
                Volume = 9;
            }
            else
            {
                Volume = newvolume;
            }
            
        }

        public void setFreq(int newfreq)
        {
            if (newfreq < 2000)
            {
                Freq = 2000;
            }
            else if (newfreq > 26000)
            {
                Freq = 26000;
            }
            else
            {
                Freq = newfreq;
            }
        }

        public override string ToString()
        {
            return "The radio is on: "+ IsOn + ", the volume is set at: "+ Volume + " and the frequency at: "+Freq;
        }

    }
}
