using System;

namespace _3.Типы_значений_и_ссылочные_типы
{
    /**
     * В стек помещаются типы значений и ссылки на ссылочные типы.
     * В свою очередь ссылочные типы помещаются в кучу.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(5);

            /**
             * В стек попадут все поля структуры и ссылка на объект country1,
             * поля которого находятся в куче.
             */
            State state1 = new State();
            Country country1 = new Country();

            /**
             * Так как state1 - структура, то при присвоении state1 = state2 
             * она получает копию структуры state2. А объект класса country1
             * при присвоении country1 = country2; получает ссылку на тот же
             * объект, на который указывает country2. Поэтому с изменением country2,
             * так же будет меняться и country1.
             */
            State state11 = new State(); // Структура State
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state11 = state2;
            state2.x = 5;
            Console.WriteLine(state11.x); // 1
            Console.WriteLine(state2.x); // 5

            Country country11 = new Country();
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country11 = country2;
            country2.x = 7;
            Console.WriteLine(country11.x); // 7
            Console.WriteLine(country2.x); // 7

            // Ссылочные типы внутри типов значений
            State state12 = new State();
            State state22 = new State();

            state22.country = new Country();
            state22.country.x = 5;
            state12 = state22;
            state22.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                                  // указывают на один объект в хипе
            Console.WriteLine(state12.country.x); // 8
            Console.WriteLine(state22.country.x); // 8

            // Объекты классов как параметры методов

            // Если мы хотим, поменять объект p, используя метод ChangePerson, необходимо передавать ссылку на объект.
            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            Console.ReadKey();
        }

        /// <summary>
        /// Параметры и переменные метода помещаются в стек
        /// </summary>
        /// <param name="t"></param>
        static void Calculate(int t)
        {
            /**
             * При вызове метода в стек поместятся переменные x, y, z, t.
             * После отработки метода, данные из стека будут очищены.
             */
            int x = 6;
            int y = 7;
            int z = y + t;
        }

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }
    }

    struct State
    {
        public int x;
        public int y;
        public Country country;
    }

    class Country
    {
        public int x;
        public int y;
    }

    class Person
    {
        public string name;
        public int age;
    }
}
