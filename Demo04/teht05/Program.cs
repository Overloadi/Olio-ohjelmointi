using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio ratio = new Radio();
            ratio.powerSwitch(true);
            ratio.setVolume(5);
            ratio.setFreq(199000);
            Console.WriteLine(ratio.ToString());
        }
    }
}
