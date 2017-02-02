using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator kone = new Elevator();
            string input;
            int floor;
            while (true)
            {
                Console.WriteLine("Elevator is currently in floor number " + kone.CurrentFloor);
                Console.WriteLine("Select which floor to go to (1-5) > ");
                input = Console.ReadLine();
                floor = int.Parse(input);
                kone.CurrentFloor = floor;
            }
        }
    }
}
