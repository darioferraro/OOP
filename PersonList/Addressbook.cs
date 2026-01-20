using PersonList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonList
{
    internal class Addressbook
    {

        /** A list to store Person objects */
        private List<Person> persons;



        /** Constructor to initialize the Addressbook */
        public Addressbook()
        {
            persons = new List<Person>();
        }
        // Method to add a Person to the Addressbook
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        //print all persons in the addressbook
        public void PrintAllPersons()
        {
            foreach (var person in persons)
            {
                person.PrintPerson();
            }
        }
        public List<Person> FindPersonByName(string name)
        {
            var result = from p in persons
                         where p.Name == name
                         select p;
            return result.ToList();
        }

        public void PrintPersonByName(string name)
        {
            var foundPersons = FindPersonByName(name);
            foreach (var person in foundPersons)
            {
                person.PrintPerson();
            }
        }

        public List<Person> FindPersons(string name, string street, short nr, short zip)
        {
            var result =
                from p in persons
                where p.Name == name
                   && p.Address.Street == street
                   && p.Address.Nr == nr
                   && p.Address.Zip == zip
                select p;

            return result.ToList();
        }


        public List<Person> OrderAdressBook()
        {
            var result = from p in persons
                         orderby p.Name, p.Age
                         select p;
            return result.ToList();
        }
        public List<Person> FindPersonByAdress(string street, short nr, short zip)
        {             var result = from p in persons
                         where p.Name == street
                         select p;
            return result.ToList();
        }
    }
}



