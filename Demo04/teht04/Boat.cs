using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Boat : Vehicle
    {
        public int SeatCount;
        public string BoatType;

        public Boat(string name, string model, int modelyear, string color, int seatcount, string boattype)
            :base(name,model,modelyear,color)
        {
            this.SeatCount = seatcount;
            this.BoatType = boattype;
        }

        public override string ToString()
        {
            return base.ToString() + " Seat count: "+this.SeatCount+" Boat type: "+this.BoatType;
        }
    }
}
