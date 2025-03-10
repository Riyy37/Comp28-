using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    /// <summary>
    /// Дано: курс рубля России за февраль 2020
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double[] mas = { 63.5, 63.2, 63.57, 62.87, 64.31, 63.5, 63.24, 64.12, 62.59, 63.78, 63.42, 63.77 };
            Idk(mas);
            Console.ReadKey();
        }
        static void Idk (double[]mas)
        {
            double average = mas.Average();

            double max = mas.Max();
            double min = mas.Min();

            int maxDay = Array.IndexOf(mas, max) + 1;
            int minDay = Array.IndexOf(mas, min) + 1;

            Console.WriteLine($"Среднее значение ЗП = {average:F2}");
            Console.WriteLine($"Максимальная ЗП в {maxDay} день равна {max:F2}");
            Console.WriteLine($"Минимальная ЗП в {minDay} день равна {min:F2}");
        }
    }
}
