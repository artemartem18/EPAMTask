/*
 * Задание 4 Факториал
 Написать функцию нахождения факториала числа n.
 */
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите факториал");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>= 0)
            {
                Console.WriteLine($"Факториал числа {n}: {Factorial(n)}");
            }
            else
            {
                Console.WriteLine("Было введено отрицательное число!");
            }
            Console.ReadKey();
         static int Factorial(int n)
            {
                int factorial = 1;
                if (n > 0)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        factorial *= i;
                    }
                }
                return factorial;
            }
        }
    }
}
