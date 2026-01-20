using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    internal class Address
    {
        private string street;
        private short nr;
        private short zip;
        private string city;
        public string Street { get { return street; } set => street = value; }
        public short Nr { get { return nr; }
            set
            {
                if (value >= 0)
                {
                    nr = value;
                }
                else
                {
                    Console.WriteLine("House number cannot be negative.");
                }
            }
        }
        public short Zip
        {
            get { return zip; }
            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    zip = value;
                }
                else
                {
                    Console.WriteLine("ZIP code must be between 1000 and 9999.");
                }
            }
        }
        public string City { get { return city; } set => city = value; }

        public Address(string street, short nr, short zip, string city)
        {
            this.street = street ?? throw new ArgumentNullException(nameof(street));
            this.nr = nr;
            this.zip = zip;
            this.city = city ?? throw new ArgumentNullException(nameof(city));
        }
    }
}
