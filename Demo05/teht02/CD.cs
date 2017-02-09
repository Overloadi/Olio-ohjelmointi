using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs = new List<Song>();

        public CD(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
        public override string ToString()
        {
            StringBuilder songsappended = new StringBuilder();
            
            foreach (Song song in Songs)
            {
                songsappended.Append("  - "+song.ToString()+"\r\n");
            }
            return "CD data:\r\n- name: " + Name + "\r\n- artist: " + Artist + "\r\n- songs:\r\n"+songsappended.ToString(); 
        }
        public void addSong(Song song)
        {
            Songs.Add(song);
        }
    }
}
