using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Postfix
    {
        public string Expression { get; set; }
        public string[] Elements { get; set; }
        public string[] Result { get; set; }

        public Postfix(string expression)
        {
            Elements = new string[expression.Length];
            Expression = expression;
            for (int i = 0; i < expression.Length; i++)
            {
                Elements[i] = expression[i].ToString();
            }
        }

        private bool IsDigit(string value)
        {
            string[] digits = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            return digits.Contains(value);
        }

        public string CreatePostfix()
        {
            var result = string.Empty;

            for (int i = 0; i < Elements.Length; i++)
            {
                if (IsDigit(Elements[i]))
                {
                    result += Elements[i];
                }
                else
                {
                    result += Elements[i + 1];
                    result += Elements[i];
                    i += 1;
                }
            }
            Result = new string[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                Result[i] = result[i].ToString();
            }

            return result;
        }

        public int GetResult()
        {
            var stack = new Stack<int>();
            var result = 0;

            for (int i = 0; i < Result.Length; i++)
            {
                if (IsDigit(Result[i]))
                {
                    stack.Push(Convert.ToInt32(Result[i]));
                }
                else
                {
                    if (Result[i] == "+")
                    {
                        while (stack.Count != 0)
                        {
                            result += stack.Pop();
                        }
                    }
                }
            }
            return result;
        }
    }
}
