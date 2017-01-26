using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Television
    {
        public bool tvOn {get;set;}
        public int channel { get; set; }
        public int volume { get; set; }

        public void channelUp()
        {
            channel++;
        }
        public void channelDown()
        {
            channel--;
        }
        public void setChannel(int chan)
        {
            channel = chan;
        }
        public void volumeUp()
        {
            volume++;
        }
        public void volumeDown()
        {
            volume--;
        }
        public void turnOn(bool state)
        {
            tvOn = state;
        }
    }
}
