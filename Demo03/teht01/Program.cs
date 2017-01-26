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
            Kiuas harvia = new Kiuas();
            harvia.laitaPaalle();
            harvia.saadaKosteutta(30);
            harvia.saadaLampotilaa(100);
            Console.WriteLine(harvia.lampotila);
            Console.WriteLine(harvia.paalla);
            Console.WriteLine(harvia.kosteus);
            harvia.laitaPoisPaalta();
            Console.WriteLine(harvia.paalla);
        }
    }
}
