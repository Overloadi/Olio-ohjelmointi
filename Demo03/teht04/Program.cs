using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle autoo = new Vehicle();
            autoo.Name = "Ooppeli";
            autoo.Tyres = 3;
            autoo.Speed = 60;
            autoo.PrintData();
            string joku = autoo.ToString();
            Console.WriteLine(joku);
        }
    }
}
