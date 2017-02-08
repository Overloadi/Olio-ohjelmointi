using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Cookie
    {
        public string Name;
        public double Price;
        public string Manufacturer;
        public bool IsEaten = false;

        public Cookie(string name, double price, string manufacturer)
        {
            this.Name = name;
            this.Price = price;
            this.Manufacturer = manufacturer;
        }
        public void eatCookie()
        {
            IsEaten = true;
        }

        public override string ToString()
        {
            return "The cookie is called "+Name+" a package costs "+Price+" Euros, it has been manufactured by "+Manufacturer+ ". The cookie has been eaten: "+IsEaten;
        }
    }

    class Domino : Cookie
    {
        public string Filling;
        public bool HasFilling = true;

        public Domino(string name, double price, string manufacturer, string filling)
            :base(name,price,manufacturer)
        {
            this.Filling = filling;
        } 
        public void eatFilling()
        {
            HasFilling = false;
        }
        public override string ToString()
        {
            return base.ToString()+ ". The cookies has filling called " + Filling + " and it still has it: "+HasFilling;
        }
    }

}
