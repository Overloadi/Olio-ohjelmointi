using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            int[] pisteet = new int[5];
            int sum = 0;
            int kokpisteet = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Anna pisteet > ");
                input = Console.ReadLine();
                number = int.Parse(input);
                pisteet[x] = number;
            }
            sum = pisteet.Sum();
            int max = pisteet.Max();
            int min = pisteet.Min();
            kokpisteet = sum - max - min;
            Console.WriteLine("Kokonaispisteet ovat " + kokpisteet);
        }
    }
}
