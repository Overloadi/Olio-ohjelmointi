using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Boss : Employee
    {
        public string Car;
        public int Bonus;
        public Boss(string name, string profession, int salary, string car, int bonus)
            :base(name,profession,salary)
        {
            this.Name = name;
            this.Profession = profession;
            this.Salary = salary;
            this.Car = car;
            this.Bonus = bonus;
        }

        public void changeCar(string newcar)
        {
            this.Car = newcar;
        }

        public void changeBonus(int newbonus)
        {
            this.Bonus = newbonus;
        }

        public override string ToString()
        {
            return base.ToString() + " Car: " + this.Car + " Bonus: " + this.Bonus;
        }
    }
}
