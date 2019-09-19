using System;

namespace _6.Ковариантность_и_контравариантность_делегатов
{
    class Program
    {
        delegate Person PersonFactory(string name);
        delegate void ClientInfo(Client client);
        delegate T Builder<out T>(string name);

        static void Main(string[] args)
        {
            PersonFactory personFactory;
            personFactory = x => new Client { Name = x }; // Ковариантность
            Person person = personFactory("Ruslan");
            Console.WriteLine(person.Name); // Ruslan

            ClientInfo clientInfo = GetPersonInfo; // контравариантность
            Client client = new Client { Name = "Tom" };
            clientInfo(client);

            Builder<Client> clientBuilder = GetClient;
            Builder<Person> personBuilder1 = clientBuilder;
            Builder<Person> personBuilder2 = GetClient;

            Person p = personBuilder1("Tom");
            p.Display();
        }

        private static void GetPersonInfo(Person p)
        {
            Console.WriteLine(p.Name);
        }

        private static Person GetPerson(string name)
        {
            return new Person { Name = name };
        }
        private static Client GetClient(string name)
        {
            return new Client { Name = name };
        }
    }

    class Person
    {
        public string Name { get; set; }

        public virtual void Display() => Console.WriteLine($"Person {Name}");
    }

    class Client : Person
    {
        public override void Display() => Console.WriteLine($"Client {Name}");
    }
}
