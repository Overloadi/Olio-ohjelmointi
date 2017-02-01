using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Computer
    {
        public string GraphicsCard { get; set; }
        public string Processor { get; set; }
        public double ProcessorFrequency { get; set; }
        public int ProcessorCores { get; set; }
        public string Motherboard { get; set; }
        public int RandomAccessMemory { get; set; }
        public int PSUPowerOutput { get; set; }
        public bool OnOff { get; set; }

        public void Power(bool set) {
            OnOff = set;
        }

        public void PrintData()
        {
            Console.WriteLine("The computer has a " + GraphicsCard + ", " + Processor + " processor, that has a frequency of " + ProcessorFrequency + " GHz and " + ProcessorCores + " cores. The motherboard is called " + Motherboard + ", Power supply output is " + PSUPowerOutPut + " W and the computer has " + RandomAccessMemory + " GB RAM."  );
        }

    }
}
