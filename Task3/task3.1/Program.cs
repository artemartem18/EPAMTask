/*
 * Задание 3. Строки
 Дана строка, вывести только те слова, которые встречаются в ней только один раз.
 */
using System;

namespace task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Как сделать так Как чтобы сделать вывести только те слова, те которые встречаются в которые тексте только один раз";
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            var words = stroka.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Task3(words);
            static void Task3(string []words)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    int n = 0;
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i == j) continue;
                        if (words[i] == words[j]) n++;
                    }
                    if (n == 0)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
                Console.ReadKey();
            }
        }






    }
    
}
           
            
            
           