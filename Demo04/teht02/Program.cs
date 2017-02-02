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
            Amplifier vahvari = new Amplifier();
            string input;
            int volume;
            while (true)
            {
                Console.WriteLine("Current volume is " + vahvari.CurrentVolume);
                Console.WriteLine("Set the amplifier volume (0-100) > ");
                input = Console.ReadLine();
                volume = int.Parse(input);
                vahvari.CurrentVolume = volume;
            }
        }
    }
}
