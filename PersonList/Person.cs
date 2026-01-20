using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Person
    {
        private string name;
        private short age;
        public short password;
        private Address address;
     

        public string Name { get { return name; } set => name= value; }

        public Address Address
        {
            get { return address; }
        }
        public short Age
        {
            set
            {
                if (age >= 0 && age <= 140)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("age ist not in the range");
                }
            }
            get { return age; }
        }



        public void PrintPerson()
        {
            Console.WriteLine("My Name is: " + name);
            Console.WriteLine("Age: " + age);
        }

        public Person(string name, short age,string street, short nr, short zip, string city)
        {
            // mit this ist immer das Objekt gemeint
            Name = name;

            Age = age;

            address = new Address(street, nr, zip, city);



        }
    }
}
