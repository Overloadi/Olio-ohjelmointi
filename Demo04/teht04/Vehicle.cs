using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Vehicle
    {
        public string Name;
        public string Model;
        public int ModelYear;
        public string Color;

        public Vehicle(string name, string model, int modelyear, string color)
        {
            this.Name = name;
            this.Model = model;
            this.ModelYear = modelyear;
            this.Color = color;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Model:" + this.Model + " Model Year:" + this.ModelYear + " Color:" + this.Color;
        }
    }
}
