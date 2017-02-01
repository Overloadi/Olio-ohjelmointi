using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Opiskelijan nimi on " + Name + ", tunnus on " + ID + ", ikä on " + Age + " ja osoite on " + Address);
        }
    }
}
