using System;
using System.Collections;
using System.Collections.Generic;

namespace CheckBrackets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine().Replace(" ","");
            Stack<char> stack = new Stack<char>();
            bool isCorrect = true;
            try
            {
                foreach (var item in str)
                {
                    if (item == '(' || item == '{' || item == '[' || item == '<')
                    {
                        stack.Push(item);
                    }
                    else if (item == ')' || item == '}' || item == ']' || item == '>')
                    {
                        if (item == ')')
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else
                            {
                                isCorrect = false;
                                break;
                            }
                        else if (item == '}')
                            if (stack.Peek() == '{')
                                stack.Pop();
                            else
                            {
                                isCorrect = false;
                                break;
                            }
                        else if (item == ']')
                            if (stack.Peek() == '[')
                                stack.Pop();
                            else
                            {
                                isCorrect = false;
                                break;
                            }
                        else if (item == '>')
                            if (stack.Peek() == '<')
                                stack.Pop();
                            else
                            {
                                isCorrect = false;
                                break;
                            }
                    }
                }
            }
            catch
            {
                isCorrect = false;
            }
            if (stack.Count != 0)
                isCorrect = false;
            Console.WriteLine(isCorrect);
        }
    }
}
