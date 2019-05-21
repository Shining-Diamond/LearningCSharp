using System;

namespace _4.Модификаторы_доступа
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();

            // state1.a = 4; Нет доступа
            // state1.b = 4; Нет доступа
            // state1.c = 4; Нет доступа. Класс Program не является наследником State

            state1.d = 5; // Есть доступ.
            state1.e = 4; // Есть доступ.
            state1.f = 1; // Есть доступ.

            // state1.Display_f(); Нет доступа
            // state1.Display_e(); Нет доступа. Класс Program не является наследником State
            state1.Display_a(); // Метод доступен
            state1.Display_b(); // Метод доступен в любом месте программы, но недоступен для сборок и других программ

            Console.ReadKey();
        }
    }

    public class State
    {
        int a; // все равно, что private int a;
        private int b; // поле доступно только из текущего класса
        protected int c; // доступно из текущего класса и производных классов
        internal int d; // доступно в любом месте программы
        protected internal int e; // доступно в любом месте программы и из классов-наследников
        public int f; // доступно в любом месте программы, а также для других программ и сборок
        protected private int g; // доступно из текущего класса и производных классов, которые определены в том же проекте

        private void Display_f()
        {
            Console.WriteLine($"Переменная f = {f}");
        }

        public void Display_a()
        {
            Console.WriteLine($"Переменная a = {a}");
        }

        internal void Display_b()
        {
            Console.WriteLine($"Переменная b = {b}");
        }

        protected void Display_e()
        {
            Console.WriteLine($"Переменная e = {e}");
        }
    }
}
