using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine kone = new WashingMachine();
            kone.openHatch(true);
            kone.openHatch(false);
            kone.setTemperature(20);
            kone.setProgram("kirjopesu");
            kone.setTime(40);
            kone.turnOn(true);
            Console.WriteLine(kone.time + kone.temperature + kone.program + kone.machineOn + kone.hatchOpen);
        }
    }
}
