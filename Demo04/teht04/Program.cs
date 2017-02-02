using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike havytonjopo = new Bike("Hävytön jopo", "Urban", 1990, "All black",true, "UG");
            Bike jaatavajopo = new Bike("Jäätävä jopo", "Ghetto", 2005, "All white", false, "");
            Boat juliet = new Boat("Juliet", "A1205", 1969, "White", 4, "Motorboat");
            Console.WriteLine(havytonjopo.ToString());
            Console.WriteLine(jaatavajopo.ToString());
            Console.WriteLine(juliet.ToString());
        }
    }
}
