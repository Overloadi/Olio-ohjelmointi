using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Employee
    {
        public string Name;
        public string Profession;
        public int Salary;

        public Employee(string name, string profession, int salary)
        {
            this.Name = name;
            this.Profession = profession;
            this.Salary = salary;
        }

        public void changeSalary(int newsalary)
        {
            this.Salary = newsalary;
        }

        public void changeProfession(string newprofession)
        {
            this.Profession = newprofession;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " Profession: " + this.Profession + " Salary: " + this.Salary;
        }

    }
}
