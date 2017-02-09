using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Song
    {
        public string Name { get; set; }
        public string SongLength { get; set; }

        public Song(string name, string songlength)
        {
            Name = name;
            SongLength = songlength;
        }
        public override string ToString()
        {
            return Name + " , " + SongLength;
        }
    }
}
