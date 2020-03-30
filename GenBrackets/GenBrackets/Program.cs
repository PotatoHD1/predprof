using System;
using System.Collections.Generic;
using System.Threading;

namespace GenBrackets
{
    class MainClass
    {
        static string Output(int[,] brMassive) //Вывод, принимает на вход массив скобочной последовательности
        {
            char[] preOutput = new char[brMassive.GetLength(1) * 2]; //Создаем строчку вывода
            for (int i = 0; i < brMassive.GetLength(1); i++)
            {
                preOutput[brMassive[0, i]] = GetBr(brMassive[2, i], true); //добавляем в строку вывода открывающую скобку
                preOutput[brMassive[1, i]] = GetBr(brMassive[2, i], false); //добавляем в строку вывода закрывающую скобку
            }
            return new string(preOutput);
        }
        static char GetBr(int type, bool opening)
        {
            switch (type)
            {
                case 0: return opening ? '(' : ')';
                case 1: return opening ? '[' : ']';
                case 2: return opening ? '{' : '}';
                case 3: return opening ? '<' : '>';
                default: return ' ';
            }
        }
        static bool PlusBr(ref int[,] brMassive, int brType)
        {
            int res = 0;
            for (int i = 0; i < brMassive.GetLength(1); i++)
            {
                
                res += brMassive[2, i] * (int)Math.Pow(brType, brMassive.GetLength(1) - i - 1);
            }
            res--;            
            if (res >= 0)
            {
                if (brMassive.GetLength(1) == 1)
                {
                    brMassive[2, 0] = res;
                }
                else
                {
                    string res1 = "";
                    do
                    {
                        res1 = (res % brType).ToString() + res1;
                        res /= brType;

                    } while (res >= brType);
                    res1 = res.ToString() + res1;
                    while (res1.Length < brMassive.GetLength(1))
                    {
                        res1 = "0" + res1;

                    }
                    for (int i = 0; i < brMassive.GetLength(1); i++)
                    {
                        brMassive[2, i] = int.Parse(res1[i].ToString());
                    }
                }                
                return true;
            }
            return false;
        }
        static bool GenMassive(ref int[,] brMassive)
        {
            if (GenFirstLine(ref brMassive))
            {
                GenSecondLine(ref brMassive);
                return true;
            }
            return false;
        }        
        static void FirstGenMassive(ref int[,] brMassive)
        {
            for (int i = 1; i < brMassive.GetLength(1); i++)
            {
                brMassive[0, i] = i;
                brMassive[2, i] = brMassive[2, 0];
            }
            GenSecondLine(ref brMassive);
        }
        static bool GenFirstLine(ref int[,] brMassive)
        {
            for (int i = 0; i < brMassive.GetLength(1); i++)
            {
                brMassive[1, i] = 0;
            }
            for (int i = brMassive.GetLength(1) - 1; i > 0; i--)
            {
                if (brMassive[0, i] + 1 <= i * 2)
                {
                    brMassive[0, i]++;
                    for (int j = i; j < brMassive.GetLength(1) - 1; j++)
                    {
                        if (brMassive[0, j + 1] >= brMassive[0, j])
                        {
                            brMassive[0, j + 1] = brMassive[0, j] + 1;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        static void GenSecondLine(ref int[,] brMassive)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < brMassive.GetLength(1) * 2; i++)
                numbers.Add(i);

            for (int i = 0; i < brMassive.GetLength(1) - 1; i++)
            {
                numbers.Remove(brMassive[0, i + 1]);
                if (brMassive[0, i + 1] != brMassive[0, i] + 1)
                {
                    brMassive[1, i] = brMassive[0, i] + 1;
                    numbers.Remove(brMassive[1, i]);
                }
            }

            for (int i = brMassive.GetLength(1) - 1; i >= 0; i--)
            {
                if (numbers.Count > 0 && brMassive[1, i] == 0)
                {
                    brMassive[1, i] = numbers[0];

                    numbers.RemoveAt(0);
                }
                else if (numbers.Count == 0)
                    return;
            }
        }

        public static void Main(string[] args)
        {
            //Ввод данных
            string[] input = Console.ReadLine().Split(' ');
            int brCount, brType; //brCount -  длина скобочной последовательности, brType - количество типов скобок
            if (input.Length != 1)
            {
                brCount = int.Parse(input[0]);
                brType = int.Parse(input[1]);
            }
            else
            {
                brCount = int.Parse(input[0]);
                brType = int.Parse(Console.ReadLine());
            }
            if (brCount % 2 != 0) //Проверка на чётность, очевидно если количество скобочек нечетное, правильную последовательность сгенерировать невозможно
            {
                Console.WriteLine("NO");
                return;
            }
            int[,] brMassive = new int[3, brCount / 2];
            //Массив для построения скобочной последовательности
            // 0 1 3 6 ряд, отвечающий за открывающиеся скобочки. Заполнен индексами позиций, на которых должны стоять открывающиеся скобки
            // 7 2 4 5 ряд, отвечающий за закрывающиеся скобочки. Заполнен индексами позиций, на которых должны стоять закрывающиеся скобки
            // 1 0 2 3 ряд, отвечающий за тип скобочек. Он представляет число в системе исчесления n, где n = brType + 1
            // например для brType = 1 система будет двоичная, для brType = 3 - четверичная

            brMassive[2, 0] = brType - 1;
            int j = 0;
            FirstGenMassive(ref brMassive);
            if (brType > 1)
            {
                do
                {
                    for (int i = 0; i < brMassive.GetLength(1); i++)
                    {
                        brMassive[2, i] = brType - 1;
                    }
                    do
                    {
                        j++;
                        Console.Write(Output(brMassive) + " ");
                    } while (PlusBr(ref brMassive, brType));


                } while (GenMassive(ref brMassive));
            }
            else
            {
                do
                {
                    j++;
                    Console.Write(Output(brMassive) + " ");

                } while (GenMassive(ref brMassive));

            }
            Console.WriteLine();
            Console.WriteLine(j);
        }
    }
}
