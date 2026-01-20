namespace PersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Alice", 30));
            persons.Add(new Person("Bob", 25));
            persons.Add(new Person("Charlie", 25));

            foreach (var person in persons)
            {
                person.PrintPerson();
            }

            Console.WriteLine();
            Console.WriteLine("ForEach LINQ-Methode:");

            persons.ForEach(person => person.PrintPerson());


            Console.WriteLine();
            Console.WriteLine("Who the fxxx is Alice:");

            var result = from p in persons
                         where p.Name == "Alice"
                         select p;


            foreach (var person in result)
                person.PrintPerson();


            

            Console.WriteLine("************Adressbook************");
            Addressbook addressBook = new Addressbook();
            addressBook.AddPerson(new Person("David", 40));
            addressBook.AddPerson(new Person("Eve", 35));
            addressBook.AddPerson(new Person("David", 28));
            addressBook.PrintAllPersons();


            Console.WriteLine();
            Console.WriteLine("Who is David:");
            addressBook.PrintPersonByName("David");

        }
    }
}
