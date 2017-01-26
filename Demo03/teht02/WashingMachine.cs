using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class WashingMachine
    {
        public int temperature { get; set; }
        public string program { get; set; }
        public int time { get; set; }
        public bool machineOn { get; set; }
        public bool hatchOpen { get; set; }

        public void setTemperature(int temp)
        {
            temperature = temp;
        }

        public void turnOn(bool state)
        {
            machineOn = state;
        }

        public void openHatch(bool state)
        {
            hatchOpen = state;
        }

        public void setProgram(string prog)
        {
            program = prog;
        }
        public void setTime(int timer)
        {
            time = timer;
        }
    }
}
