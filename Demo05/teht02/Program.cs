using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD stokiss = new CD("Stökiss","Eevil Stöö");
            Song outro = new Song("Outro", "3:36");
            Song arm = new teht02.Song("Anti-Rain Mane", "3:20");
            Song sano = new Song("Älä sano mitään", "3:25");
            Song og = new teht02.Song("Taatusti OG", "2:28");
            stokiss.addSong(outro);
            stokiss.addSong(arm);
            stokiss.addSong(sano);
            stokiss.addSong(og);
            Console.WriteLine(stokiss.ToString());
        }
    }
}
