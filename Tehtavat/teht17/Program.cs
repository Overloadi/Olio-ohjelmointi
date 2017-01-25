using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut1 = { 10, 20, 30, 40, 50 };
            int[] luvut2 = { 5, 15, 25, 35, 45 };
            int[] yhdistettyluvut = new int[luvut1.Length + luvut2.Length];
            Array.Copy(luvut1, yhdistettyluvut, luvut1.Length);
            Array.Copy(luvut2, 0, yhdistettyluvut, luvut1.Length, luvut2.Length);
            Array.Sort(yhdistettyluvut);
            Console.Write("Luvut taulukossa 1 : ");
            foreach (int luku in luvut1)
            {
                Console.Write(luku + " ");
            }
            Console.Write("\r\nLuvut taulukossa 2 : ");
            foreach (int luku in luvut2)
            {
                Console.Write(luku + " ");
            }
            Console.Write("\r\nLuvut yhdistetyssä taulukossa : ");
            foreach (int luku in yhdistettyluvut)
            {
                Console.Write(luku + " ");
            }

        }
    }
}
