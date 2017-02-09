using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Persons
    {
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add a person to the collection
        /// </summary>
        /// <param name="person">Person that gets added</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person GetPerson(int index)
        {
            if (index < persons.Count && index >= 0)
            {
                return persons.ElementAt(index);
            }
            else return null;
        }
        public Person FindPerson(string SocialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                if (SocialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null;
        }
        public void PrintData()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
