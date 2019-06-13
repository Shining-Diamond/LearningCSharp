using System;

namespace _1.Введение_в_интерфейсы
{
    class Program
    {
        static void Action(IMovable movable)
        {
            movable.Move();
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();

            Action(person);
            Action(car);

            Client client = new Client("Tom", 200);
            client.Put(30);

            Console.WriteLine(client.CurrentSum); // 230

            client.Withdraw(100);

            Console.WriteLine(client.CurrentSum); // 130

            // Преобразование интерфейсов

            // Все объекты Client являются объектами IAccount 
            IAccount account = new Client("Том", 200);

            account.Put(200);

            Console.WriteLine(account.CurrentSum); // 400

            // Не все объекты IAccount являются объектами Client, необходимо явное приведение
            Client clientNew = (Client)account;

            // Интерфейс IAccount не имеет свойства Name, необходимо явное приведение
            string clientName = ((Client)account).Name;

            Console.ReadKey();
        }
    }

    interface IMovable
    {
        void Move();
    }

    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Человек идет");
        }
    }

    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }

    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }

    interface IClient
    {
        string Name { get; set; }
    }

    class Client : IAccount, IClient
    {
        int _sum;
        public string Name { get; set; }

        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
 
        public int CurrentSum { get { return _sum; } }
 
        public void Put(int sum) {  _sum += sum; }
 
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
}
