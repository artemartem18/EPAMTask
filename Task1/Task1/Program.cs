/*
 * Задание 1. Сортировка
 Дан массив целых чисел. Напишите функцию, которая получает данный массив в 
 качестве аргумента и сортирует его по возрастанию, а также программу для демонстрации работы этой функции.
 */
using System;

namespace Task1
{
    class Program
    {
        public static void Main()
        {
            var myArray = new int[] { 100, 54, 32, 111, 243, 4531, 543, 5467, 879, 9888, 5464, 4234, 5467, 7889, 23456 };
            Task1(myArray);

        }
        static void Task1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }

                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
