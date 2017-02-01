using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vehicle's name is " + Name + ", it has " + Tyres.ToString() + " tyres and its going " + Speed.ToString() + " km/h");
        }

        public override string ToString()
        {
            string data = Name + Speed.ToString() + Tyres.ToString();
            return data;
        }
    }
}
