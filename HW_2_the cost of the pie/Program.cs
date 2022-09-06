using System;

namespace the_cost_of_the_pie
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Определите, сколько гривен и копеек нужно заплатить за n пирожков");
            Console.WriteLine("---");

            Console.WriteLine("Введите стоимость 1 пирожка:");
            Console.WriteLine("грн:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("коп:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество пирожков");
            int c = int.Parse(Console.ReadLine());




            int uah = a * c; // uah = кол-во гривен за все пирожки
            int uah1 = uah * 100; //uah2 = переводим гривны в копейки
            int cent = (b * c); // cent = кол-во копеек за все пирожки
            int centLast = cent % 100; // centLast = приводим к копейкам по остатку от деления
            int centAll = uah1 + cent; //вся сумма в копейках
            double uahCent = centAll / 100; // uahCent приводим к гривне

            Console.WriteLine("-------------------");
            Console.WriteLine($"uah = кол-во гривен за все пирожки  {uah}");
            Console.WriteLine($"uah2 = переводим гривны в копейки  {uah1}");
            Console.WriteLine($"cent = кол-во копеек за все пирожки  {cent}");
            Console.WriteLine($"centLast = приводим к копейкам по остатку от деления  {centLast}");
            Console.WriteLine($"вся сумма в копейках  {centAll}");
            Console.WriteLine($"uahCent приводим к гривне  {uahCent}");
            Console.WriteLine("---");
            Console.WriteLine("Итого:");
            Console.WriteLine($"{uahCent}грн {centLast}коп");





        }
    }
}

