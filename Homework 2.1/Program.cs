using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1: Решение одной длинной формулой.");
            double x;
            double z;
            double k;
            x = GetNum("x");
            z = GetNum("z");
            k = GetNum("k");
            GetAnswer(x, z, k);
            Console.ReadKey();
        }
        static double GetNum(string str)
        {
            while (true)
            {
                Console.Write("Введите значение: {0} = ", str);
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                Console.WriteLine("Внимание, введено не число!");
            }
        }
        static void GetAnswer(double x, double z, double k)
        {
            Console.WriteLine($"Одной формулой: y = {(Math.Sqrt(2 * x + 3 * Math.Pow(x, 2) + 4 * Math.Pow(x, 3)) + (19 * z / 15 * k)) / (Math.Sqrt(2 * z + Math.Pow(x, 4)) - 24 * z * (x + 7))}");
        }
    }
}
