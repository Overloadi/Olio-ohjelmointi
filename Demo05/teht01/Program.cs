using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons jatkat = new Persons();
            Person p1 = new Person { Firstname = "Mankine", Lastname = "Mankine", SocialSecurityNumber = "KO4312" };
            Person p2 = new Person { Firstname = "Tanja", Lastname = "Poutanen", SocialSecurityNumber = "EB1N" };
            Person p3 = new Person { Firstname = "Jaska", Lastname = "Pate", SocialSecurityNumber = "DDD3X" };
            jatkat.AddPerson(p1);
            jatkat.AddPerson(p2);
            jatkat.AddPerson(p3);
            jatkat.PrintData();
            string socialsecuritynumber = "EB1N";
            Console.WriteLine("Find person iwth social security number : " + socialsecuritynumber);
            Person p4 = jatkat.FindPerson(socialsecuritynumber);
            if (p4 != null)
            {
                Console.WriteLine(p4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find a person with that social security number");
            }

        }
    }
}
