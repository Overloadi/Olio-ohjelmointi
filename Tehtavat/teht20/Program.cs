using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace teht20
{
    class Program
    {
        // Peli, jossa käyttäjä yrittää kirjoittaa arvotun sanan mahdollisimman nopeasti. Jos sana on kirjoitettu oikein, tulostetaan kirjoittamiseen kulunut aika.
        static void Main(string[] args)
        {
            bool peli = true;
            string[] sanat = { "unelated", "frequency", "frenchness", "educator", "nonfrustration", "unstirring", "inconsiderately", "shieldlessly", "recharging", "nonspecifically" };
            Random r = new Random();
            int rand;
            string sana;
            Stopwatch kello = new Stopwatch();
            while (peli == true)
            {
                rand = r.Next(0, 10);
                sana = sanat[rand];
                Console.WriteLine("Kirjoita seuraava sana oikein mahdollisimman nopeasti, paina enter kun olet valmis ");
                string j = Console.ReadLine();
                Console.WriteLine(sana);
                kello.Start();
                string input = Console.ReadLine();
                kello.Stop();
                if (input.Equals(sana))
                {
                    TimeSpan ts = kello.Elapsed;
                    string aikaakului = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    Console.WriteLine("Aikaa kului " + aikaakului);
                }
                else
                {
                    Console.WriteLine("Kirjoitit sanan väärin");
                }
                kello.Reset();
            }
        }
    }
}
