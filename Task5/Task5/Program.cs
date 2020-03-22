/*
 * Задание 5. Правильная скобочная последовательность*
 Дана строка состоящая из скобок “{},(),[]”, определить является ли данная строка 
 правильно скобочной последовательность. Например (()) – псп, а ((() нет.
 */
using System;
using System.Collections;

namespace _5
{
    class Program
    {
        private static bool CheckLine(string str)
        {
            bool flag = true;
            char[] charArray = str.ToCharArray();
            Stack stack = new Stack();

            foreach (char i in charArray)
            {
                string item = i.ToString();
                if (item == "(" || item == "[" || item == "{")
                {
                    stack.Push(item);
                }
                else if (stack.Count > 0)
                {
                    if (item == ")")
                    {
                        if (stack.Peek().ToString() == "(")
                        {
                            stack.Pop();
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else if (item == "]")
                    {
                        if (stack.Peek().ToString() == "[")
                        {
                            stack.Pop();
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else if (item == "}")
                    {
                        if (stack.Peek().ToString() == "{")
                        {
                            stack.Pop();
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public static void Main(string[] args)
        {
            string Line = "(){{}}[()]";
            bool result = CheckLine(Line);
            if (result)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
    
}
