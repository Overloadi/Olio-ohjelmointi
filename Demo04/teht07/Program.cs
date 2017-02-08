using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie jaffa = new Cookie("Jaffakeksi", 4.40, "LU");
            Console.WriteLine(jaffa.ToString());
            jaffa.eatCookie();
            Console.WriteLine(jaffa.ToString());
            Domino domino = new Domino("Dominokeksi", 5.50, "Fazer", "mansikka");
            Console.WriteLine(domino.ToString());
            domino.eatFilling();
            Console.WriteLine(domino.ToString());
            domino.eatCookie();
            Console.WriteLine(domino.ToString());
        }
    }
}
