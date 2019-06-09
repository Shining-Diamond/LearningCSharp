using System;

namespace _18.Абстрактные_классы_и_члены_классов
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Игорь", 3000);

            client.Display(); // Игорь
            client.DispayAllInformation(); // Игорь: 3000

            Employee employee = new Employee("Василий", "Менеджер");

            employee.Display(); // Василий
            employee.DispayAllInformation(); // Василий: Менеджер

            Rectangle rectangle = new Rectangle(100, 50);

            float area = rectangle.Area(); // 5000
            float perimeter = rectangle.Perimeter(); // 300

            Console.WriteLine(area);
            Console.WriteLine(perimeter);

            Console.ReadKey();
        }
    }

    abstract class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
 
        public void Display()
        {
            Console.WriteLine(Name);
        }

        public abstract void DispayAllInformation();
    }
 
    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету
 
        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }

        public override void DispayAllInformation()
        {
            Console.WriteLine($"{Name}: {Sum}");
        }
    }
 
    class Employee : Person
    {
        public string Position { get; set; } // должность
 
        public Employee(string name, string position) 
            : base(name)
        {
            Position = position;
        }

        public override void DispayAllInformation()
        {
            Console.WriteLine($"{Name}: {Position}");
        }
    }

    abstract class Figure
    {
        // абстрактный метод для получения периметра
        public abstract float Perimeter();
        // абстрактный метод для получения площади
        public abstract float Area();
    }

    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }
 
        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        // переопределение получения периметра
        public override float Perimeter()
        {
            return (Width + Height) * 2;
        }

        // переопределение получения площади
        public override float Area()
        {
            return Width * Height;
        }
    }
}
