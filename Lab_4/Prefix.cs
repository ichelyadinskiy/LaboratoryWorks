using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Prefix
    {
        public string Expression { get; set; }
        public string[] Elements { get; set; }
        public string[] Result { get; set; }

        public Prefix(string expression)
        {
            Expression = expression;
            Elements = new string[expression.Length];
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

        public string CreatePrefix()
        {
            var result = string.Empty;

            for (int i = 0; i < Elements.Length; i++)
            {
                if (IsDigit(Elements[i]))
                {
                    result += Elements[i + 1];
                    result += Elements[i];
                    result += Elements[i + 2];
                    i += 2;
                }
                else
                {
                    result += Elements[i];
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
            string operation = string.Empty;

            for (int i = 0; i < Result.Length; i++)
            {
                if (!IsDigit(Result[i]))
                {
                    operation = Result[i];
                }
                else
                {
                    stack.Push(Convert.ToInt32(Result[i]));
                }
            }

            if (operation == "+")
            {
                while (stack.Count != 0)
                {
                    result += stack.Pop();
                }
            }

            return result;
        }
    }
}
