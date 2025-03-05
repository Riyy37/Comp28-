using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Ввести массив с клавиатуры, состоящий из 14 элементов целого типа. Найти количество элементов четных по значению.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[14];
            
            InPut("Введите элемент массива: ", mas);
            int evenCount = CountEvenElements(mas);
            Console.WriteLine($"Количество чётных элементов: {evenCount}");
            Console.ReadKey();
        }

        static void InPut(string message, int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(message);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int CountEvenElements(int[] mas)
        {
            int count = 0;
            foreach (int element in mas)
            {
                if (element % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
