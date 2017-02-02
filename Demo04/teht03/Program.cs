using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee niko = new Employee("niko poutanen", "siivooja", 400);
            Employee mankinen = new Employee("mankine", "sihteeri", 500);
            Boss bossi = new Boss("Bossi äiä", "CEO", 25000, "Audi A6", 9000);
            Console.WriteLine(niko.ToString());
            Console.WriteLine(mankinen.ToString());
            Console.WriteLine(bossi.ToString());
            niko.changeProfession("meemaaja");
            Console.WriteLine(niko.ToString());
        }
    }
}
