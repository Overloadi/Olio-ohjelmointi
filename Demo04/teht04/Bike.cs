using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Bike : Vehicle
    {
        public bool GearWheels;
        public string GearName;

        public Bike(string name, string model, int modelyear, string color, bool gearwheels, string gearname)
            :base(name,model,modelyear,color)
        {
            this.GearWheels = gearwheels;
            this.GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString()+" Gear Wheels: "+this.GearWheels+" Gear Name : "+this.GearName;
        }
    }
}
