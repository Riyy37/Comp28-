using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    /// <summary>
    /// Ввести целочисленный массив, состоящий из 8 элементов, инициализированный явным образом. 
    /// Поменять местами максимальный и первый элементы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[]mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            MaxFirst(mas);
            Console.Write("Массив после замены: ");
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }

        }
        static void MaxFirst(int[] mas)
        {
            int max = mas[0];
            int maxIndex = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    maxIndex = i;
                }
            }
            int temp = mas[0];
            mas[0] = mas[maxIndex];
            mas[maxIndex] = temp;
            
        }
    }
}
