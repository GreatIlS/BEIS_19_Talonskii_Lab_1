using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lb_2_Talonsky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("КР1 Задание 1");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            try
            {
                Console.WriteLine("Введите Х:= ");
                double x = Double.Parse(Console.ReadLine());
                double y;
                y = Math.Pow(Math.Pow(Math.E, 2.0 / 3.0 - x), 1.0 / 5.0) / Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(x, 4.0) + Math.Log10(Math.Abs(x - 3.4)));
                Console.WriteLine("Результат = " + y);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Введены некорректные данные.");
                Console.ReadLine();
            }


        }
    }
}
