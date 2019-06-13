using System;

namespace _2.Дополнительно_об_интерфейсах
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            ((ISchool)p).Study();
            ((IUniversity)p).Study();

            Console.ReadKey();
        }
    }

    interface IAction
    {
        void Move();
    }

    // Наследование интерфейсов
    interface IRunAction : IAction
    {
        void Run();
    }

    class BaseAction : IRunAction
    {
        public virtual void Move()
        {
            Console.WriteLine("Move");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    // Изменение реализации интерфейса в производном классе

    class HeroAction : BaseAction
    {
        public override void Move()
        {
            Console.WriteLine("Move in HeroAction");
        }
    }

    // Явное применение интерфейсов

    class Person : ISchool, IUniversity
    {
        void ISchool.Study()
        {
            Console.WriteLine("Учеба в школе");
        }
        void IUniversity.Study()
        {
            Console.WriteLine("Учеба в университете");
        }
    }

    interface ISchool
    {
        void Study();
    }

    interface IUniversity
    {
        void Study();
    }
}
