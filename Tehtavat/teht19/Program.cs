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
            char[] temp = nakyvasana.ToArray();
            int index = arvattavasana.IndexOf(arvattukirjain);
            temp[index] = arvattukirjain;
            while (index != -1)
            {
                index = arvattavasana.IndexOf(arvattavasana, index + 1);
                if (index == -1) { break; }
                temp[index] = arvattukirjain;
            }
            nakyvasana = new string(temp);
            return nakyvasana;
        }

        static void Main(string[] args)
        {
            string[] sanat =
            {
                "koira", "kissa","petteri","mutsi","johtaja","hirsipuu","yliopisto"
            };
            Random r = new Random();
            int randomindex = r.Next(0, 6);
            string arvattavasana = sanat[randomindex];
            string nakyvasana = new String('_', arvattavasana.Length);

            bool peli = true;
            string arvaus;
            char arvattukirjain;
            int arvauslaskuri = 8;
            Console.Write("Hirsipuu peli!");
            Console.WriteLine("Sanan pituus on " + arvattavasana.Length + " kirjainta");
            while (peli != false)
            {
                Console.WriteLine("Arvaa kirjain > ");
                arvaus = Console.ReadLine();
                arvattukirjain = arvaus[0]; 
                if (arvattavasana.Contains(arvaus) == true)
                {
                    nakyvasana = formatoisana(nakyvasana, arvattavasana,arvattukirjain);
                    Console.WriteLine(nakyvasana);
                }
                else
                {
                    Console.WriteLine("Arvasit väärin, sinulla on " + arvauslaskuri + " arvausta jäljellä");
                }
                arvauslaskuri--;

            }
        }
    }
}
