using System;
using System.Collections.Generic;

namespace longMath
{
    class VeryLong
    {
        const int lbase = 9;
        public List<int> value { get; private set; }
        public VeryLong(string value)
        {
            value = value.Replace(".", "").Replace(",", "");
            this.value = new List<int>();
            
            if (value.Length % lbase != 0)
                this.value.Add(int.Parse(value.Substring(0, value.Length % lbase)));
            for (int i = value.Length / lbase - 1; i >= 0; i--)
            {
                this.value.Add(int.Parse(value.Substring(value.Length - lbase * (i + 1), lbase)));
            }

        }
        public VeryLong(List<int> value)
        {
            this.value = value;
        }
        public static VeryLong operator -(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] < 0 ^ vl2.value[0] < 0)
                if (vl1.value[0] < 0)
                    return vl2 + -vl1;
                else
                    return vl1 + -vl2;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return vl2 - -vl1;
            List<int> result;
            if (vl1.value.Count <= vl2.value.Count)
            {
                while (vl1.value.Count < vl2.value.Count)
                {
                    vl1.value.Insert(0, 0);
                }
            }
            else
            {
                while (vl2.value.Count < vl1.value.Count)
                {
                    vl2.value.Insert(0, 0);
                }
            }
                result = vl1.value;
            for (int i = vl1.value.Count - 1; i >= 0; i--)
            {
                if (result[i] - vl2.value[i] >= 0)
                    result[i] -= vl2.value[i];
                else
                {
                    if (i != 0)
                    {
                        if (result[i - 1] != 0)
                        {
                            result[i] -= vl2.value[i] + (int)Math.Pow(10, lbase);
                            result[i - 1]--;
                        }
                        else
                        {
                            result[i] -= vl2.value[i];
                        }
                    }
                    else
                    {
                        result[i] -= vl2.value[i];
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == 0)
                    result.RemoveAt(0);
                else
                {
                    break;
                }
            }
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i] < 0)
                    result[i] *= -1;
            }
            return new VeryLong(result);
        }
        public static VeryLong operator -(VeryLong vl1)
        {
            List<int> result = vl1.value;
            result[0] = -result[0];
            return new VeryLong(result);
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < value.Count; i++)
            {
                string tmp = value[i].ToString();
                while (tmp.Length < lbase && i != 0)
                    tmp = "0" + tmp;
                result += tmp;
            }
            return result;
        }
        public static VeryLong operator +(VeryLong vl1, VeryLong vl2)
        {
            if (vl1.value[0] < 0 ^ vl2.value[0] < 0)
                if (vl1.value[0] < 0)
                    return vl2 - -vl1;
                else
                    return vl1 - -vl2;
            else if (vl1.value[0] < 0 && vl2.value[0] < 0)
                return -(-vl1 + -vl2);
            List<int> result;
            if (vl1.value.Count <= vl2.value.Count)
            {
                result = vl2.value;
                for (int i = vl1.value.Count - 1; i >= 0; i--)
                {
                    if (result[i] + vl1.value[i] < Math.Pow(10, lbase))
                        result[i] += vl1.value[i];
                    else
                    {
                        result[i] += vl1.value[i] - (int)Math.Pow(10, lbase);
                        if (i != 0)                        
                            result[i - 1]++;
                        
                        else                        
                            result.Insert(0, 1);
                        
                    }
                }

            }
            else
            {
                result = vl1.value;
                for (int i = vl2.value.Count - 1; i >= 0; i--)
                {
                    if (result[i] + vl2.value[i] < Math.Pow(10, lbase))
                        result[i] += vl2.value[i];
                    else
                    {
                        result[i] += vl2.value[i] - (int)Math.Pow(10, lbase);
                        if (i != 0)
                            result[i - 1]++;

                        else
                            result.Insert(0, 1);
                    }
                }
            }
            return new VeryLong(result);
        }


    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ","").Replace("(", "").Replace(")", "");
            #region ifs
            if (input.Contains("^"))
            {
                List<string> numbers = new List<string>(input.Split('^'));
                for (int i = numbers.Count - 1; i > 0; i--)
                {
                    //Pow(numbers[i-1], numbers[i]);
                }
            }
            else if (input.Contains("/") || input.Contains(":"))
            {
                List<string> numbers = new List<string>();
                if (input.Contains("/"))
                    numbers = new List<string>(input.Split('/'));
                else
                    numbers = new List<string>(input.Split(':'));
                for (int i = 0; i < numbers.Count; i++)
                {

                }
            }
            else if (input.Contains("*"))
            {
                List<string> numbers = new List<string>(input.Split('*'));
                for (int i = 0; i < numbers.Count; i++)
                {

                }
            }
            #endregion
            else if (input.Contains("-"))
            {
                string[] numbers = input.Split('-');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number -= new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }            
            else if (input.Contains("+"))
            {
                string[] numbers = input.Split('+');
                if (numbers.Length <= 1)
                {
                    Console.WriteLine("Слишком мало чисел");
                    return;
                }
                VeryLong number = new VeryLong(numbers[0]);
                for (int i = 1; i < numbers.Length; i++)
                {
                    number += new VeryLong(numbers[i]);
                }
                Console.WriteLine(number.ToString());
            }
            

        }

        /*static string Pow(string number, string pow)
        {
        if (pow == "0")
            return "1";
        else if (pow % 2 == 0)
            return Pow(number, pow / 2) * Pow(number, pow / 2);
        else
            return number * Pow(number, pow / 2) * Pow(number, pow / 2);
    }*/
    }
}
