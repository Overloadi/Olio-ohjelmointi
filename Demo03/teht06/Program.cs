using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.GraphicsCard = "GTX 960";
            comp.Motherboard = "ASUS P8P67";
            comp.Processor = "i5-2500K";
            comp.ProcessorCores = 4;
            comp.ProcessorFrequency = 3.5;
            comp.PSUPowerOutput = 600;
            comp.RandomAccessMemory = 12;
            comp.Power(true);
            comp.PrintData();
        }
    }
}
