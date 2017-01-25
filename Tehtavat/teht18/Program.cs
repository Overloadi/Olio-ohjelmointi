using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna lause > ");
            string lause = Console.ReadLine();
            bool palindromi = true;
            for (int i = 0; i < lause.Length/2; i++)
            {
                if (lause[i] != lause[lause.Length - 1 - i])
                {
                    Console.WriteLine("Lause ei ole palindromi\r\n");
                    palindromi = false;
                    break;
                }
            }
            if (palindromi == true)
            {
                Console.WriteLine("Lause on palindromi");
            }
        }
    }
}
