// See https://aka.ms/new-console-template for more information


using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("По заданным сторонам прямоугольника a и b вычислить его площадьи периметр.");
            Console.WriteLine("Пример ввода:5 и 6; Пример вывода: Area = 30 и Perimeter = 22");

            Console.WriteLine("Введите 1-ю сторону прямоугольника");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2-ю сторону прямоугольника");
            int b = int.Parse(Console.ReadLine());
            int s = a * b;
            int p = (a + b) * 2;
            Console.WriteLine("-------------------");
            Console.WriteLine("Area: умножить длину на ширину!");
            Console.WriteLine($"{a} * {b} = {s}");
            Console.WriteLine($"Area = {s}");
            Console.WriteLine("-------------------");
            Console.WriteLine("Perimeter: сложить длины всех его сторон!");
            Console.WriteLine($"({a} + {b})*{2} = {p}");
            Console.WriteLine($"Perimeter = {p}");
            Console.WriteLine("-------------_--_----");


        }
    }
}
