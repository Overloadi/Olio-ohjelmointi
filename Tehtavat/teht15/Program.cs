using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tyhjaa = 30;
            Console.Write("Anna luku > ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input - 2; i++)
            {
                string tyhja = new String(' ', tyhjaa - i);
                string vtahti = new String('*', i);
                Console.Write("\r\n" + tyhja + vtahti);
                if (i > 1)
                {
                    string otahti = new String('*', i-1);
                    Console.Write(otahti);
                }
            }
            string juurityhja = new String(' ', tyhjaa - 1);
            string juuri = new String('*', 1);
            Console.Write("\r\n" + juurityhja + juuri);
            Console.Write("\r\n" + juurityhja + juuri + "\r\n");
        }
    }
}
