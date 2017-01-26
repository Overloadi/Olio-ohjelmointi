using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Kiuas
    {
        public int lampotila { get; set; }
        public int kosteus { get; set; }
        public bool paalla { get; set; }

        public void saadaLampotilaa(int tavoitelampotila)
        {
            lampotila = tavoitelampotila;
        }

        public void saadaKosteutta(int tavoitekosteus)
        {
            kosteus = tavoitekosteus;
        }

        public void laitaPaalle()
        {
            paalla = true;
        }

        public void laitaPoisPaalta()
        {
            paalla = false; 
        }
    }
}
