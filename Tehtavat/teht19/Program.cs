using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht19
{
    class Program
    {
        public static string formatoisana(string nakyvasana, string arvattavasana, char arvattukirjain)
        {
            List<int> loydetytindexit = new List<int>();
            for (int i = arvattavasana.IndexOf(arvattukirjain); i > -1; i = arvattavasana.IndexOf(arvattukirjain, i + 1))
            {
                loydetytindexit.Add(i);
            }
            char[] temp = nakyvasana.ToArray();
            foreach (int index in loydetytindexit)
            {
                temp[index] = arvattukirjain;
            }
            nakyvasana = new string(temp);
            return nakyvasana;
        }

        static void Main(string[] args)
        {
            string[] sanat =
            {
                "koira", "kissa","morjenttes","osuuspankki","erikoinen","hirsipuu","basisti"
            };
            Random r = new Random();
            int randomindex = r.Next(0, 6);
            string arvattavasana = sanat[randomindex];
            string nakyvasana = new String('_', arvattavasana.Length);

            bool peli = true;
            string arvaus;
            char arvattukirjain;
            int arvauslaskuri = 8;
            Console.WriteLine("Hirsipuu peli!" + " Sanan pituus on " + arvattavasana.Length + " kirjainta");
            Console.WriteLine();
            while (peli != false)
            {
                Console.WriteLine("Arvaa kirjain > ");
                arvaus = Console.ReadLine();
                arvattukirjain = arvaus[0]; 
                if (arvattavasana.Contains(arvaus) == true)
                {
                    nakyvasana = formatoisana(nakyvasana, arvattavasana, arvattukirjain);
                    Console.WriteLine(nakyvasana);
                    if (nakyvasana.Equals(arvattavasana))
                    {
                        Console.WriteLine("Arvasit sanan oikein, voitit pelin");
                        peli = false;
                    }
                }
                else
                {
                    Console.WriteLine("Arvasit väärin, sinulla on " + arvauslaskuri + " arvausta jäljellä");
                }
                if (arvauslaskuri == 0)
                {
                    peli = false;
                    Console.WriteLine("Hävisit pelin, sana oli " + arvattavasana);
                }
                arvauslaskuri--;


            }
        }
    }
}
