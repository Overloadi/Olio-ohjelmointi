using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomluku = r.Next(0, 100);
            int arvattuluku;
            int arvauslaskuri = 1;
            bool arvaus = false;
            while (arvaus != true)
            {
                Console.WriteLine("Arvaa luku valilla 1-100 > ");
                arvattuluku = int.Parse(Console.ReadLine());
                if (arvattuluku > randomluku)
                {
                    Console.WriteLine("Luku on pienempi");
                }
                else if (arvattuluku < randomluku)
                {
                    Console.WriteLine("Luku on suurempi");
                }
                else if (arvattuluku == randomluku)
                {
                    Console.WriteLine("Arvasit luvun oikein " + arvauslaskuri + " kerralla" + "\r\n");
                    arvaus = true;
                }
                arvauslaskuri++;
            }
            
        }
    }
}
