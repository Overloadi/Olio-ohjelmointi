﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            tv.turnOn(true);
            tv.setChannel(20);
            tv.volumeUp();
            tv.volumeUp();
            tv.volumeUp();
            tv.volumeUp();
            tv.volumeUp();
            tv.volumeUp();
        }
    }
}
