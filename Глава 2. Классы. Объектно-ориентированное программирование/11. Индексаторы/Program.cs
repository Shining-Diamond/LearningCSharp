using System;

namespace _11.Индексаторы
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();

            people[0] = new Person() { Name = "Tim" };
            people[1] = new Person() { Name = "Tom" };

            Person tom = people[1];

            Console.WriteLine(tom?.Name); // Tom
            Console.WriteLine(people["Tim"]?.Name); // Tim

            User rob = new User();

            rob["name"] = "Rob";
            rob["email"] = "roby@gmail.ru";
            rob["phone"] = "8975468876";

            Console.WriteLine(rob["name"]); // Mr/Ms. Rob

            Matrix matrix = new Matrix();

            Console.WriteLine(matrix[0, 0]);

            matrix[0, 0] = 111;

            Console.WriteLine(matrix[0, 0]);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
    }

    class People
    {
        Person[] data;

        public People()
        {
            data = new Person[5];
        }

        // индексатор
        public Person this[int index]
        {
            get
            {
                return data[index];
            }

            set
            {
                data[index] = value;
            }
        }

        // Перегрузка индексатора
        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
        }
    }

    class User
    {
        string name;
        string email;
        string phone;

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return "Mr/Ms. " + name;
                    case "email": return email;
                    case "phone": return phone;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    }

    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }
}
