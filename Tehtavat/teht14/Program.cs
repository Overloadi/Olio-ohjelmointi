using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            int nollia = 0;
            int ykkosia = 0;
            int kakkosia = 0;
            int kolmosia = 0;
            int nelosia = 0;
            int vitosia = 0;
            int[] arvosanat = new int[7];
            for (int x = 0; x < 7; x++)
            {
                Console.WriteLine("Anna arvosana > ");
                input = Console.ReadLine();
                number = int.Parse(input);
                arvosanat[x] = number;
            }
            foreach (int luku in arvosanat)
            {
                switch (luku)
                {
                    case 0: nollia++; continue;
                    case 1: ykkosia++; continue;
                    case 2: kakkosia++; continue;
                    case 3: kolmosia++; continue;
                    case 4: nelosia++; continue;
                    case 5: vitosia++; continue; 
                }
            }
            string nollaa = new String('*', nollia);
            string ykkosta = new String('*', ykkosia);
            string kakkosta = new String('*', kakkosia);
            string kolmosta = new String('*', kolmosia);
            string nelosta = new String('*', nelosia);
            string vitosta = new String('*', vitosia);
            Console.WriteLine("Arvosanat:");
            Console.WriteLine("0: " + nollaa);
            Console.WriteLine("1: " + ykkosta);
            Console.WriteLine("2: " + kakkosta);
            Console.WriteLine("3: " + kolmosta);
            Console.WriteLine("4: " + nelosta);
            Console.WriteLine("5: " + vitosta);
        }
    }
}
