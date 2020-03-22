/*
 * Задание 2. Поиск
 Напишите функцию, которая для отсортированного маcсива целых чисел 
 определяет, содержится ли в нем заданное значение.
 */
using System;
namespace Task2
{
    class Program
    {
        static int[] a = new int[1000];
        static int n;   // число элементов
        static void Main(string[] args)
        {
            Console.Write("Ввести количество элементов: ");
            n = Convert.ToInt32(Console.ReadLine());
            // Упорядоченный по возрастанию массив       
            Console.WriteLine("Поиск в упорядоченном по возрастанию массиве");
            ArrGen();
            Comparison();
        }
        static void Comparison()
        {
            // Предмет поиска      
            Console.Write("Ввести элемент поиска: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Бинарный поиск        
            int k = BinSearch(b);
            Console.WriteLine("Бинарный поиск:");
            if (k > -1)
                Console.WriteLine("Заданное значение есть");
            else
                Console.WriteLine("нет заданного значения");
        }
        // Генератор упорядоченного по возрастанию массива
        static void ArrGen()
        {
            Random ran = new Random();
            a[0] = ran.Next(1, 6);
            Console.Write("  {0}", a[0]);
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + ran.Next(1, 6);
                Console.Write("  {0}", a[i]);
            }
            Console.WriteLine();
        }
        // Бинарный поиск
        static int BinSearch(int b)
        {
            int k;   
            int L = 0;        // левая граница
            int R = n - 1;    // правая граница
            k = (R + L) / 2;
            while (L < R - 1)
            {
                k = (R + L) / 2;
                if (a[k] == b)
                    return k; 
                if (a[k] < b)
                    L = k;
                else
                    R = k;
            }
            if (a[k] != b)
            {
                if (a[L] == b)
                    k = L;
                else
                {
                    if (a[R] == b)
                        k = R;
                    else
                        k = -1;
                };
            }
            return k;
        }
    }
}