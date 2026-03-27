using System;
using System.Collections.Generic;
using System.Globalization;

namespace Evaluator.Core
{
    public static class ExpressionEvaluator
    {
        public static double Evaluate(string infix)
        {
            string postfix = InfixToPostfix(infix);
            return Calculate(postfix);
        }
        
        private static List<string> Tokenize(string expression)
        {
            var tokens = new List<string>();
            var number = "";

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number.Length > 0)
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(c.ToString());
                }
            }

            if (number.Length > 0)
                tokens.Add(number);

            return tokens;
        }

        private static string InfixToPostfix(string infix)
        {
            var output = new Queue<string>();
            var stack = new Stack<char>();
            var tokens = Tokenize(infix);

            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    output.Enqueue(token);
                }
                else if (IsOperator(token[0]))
                {
                    if (token == "(")
                    {
                        stack.Push('(');
                    }
                    else if (token == ")")
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                            output.Enqueue(stack.Pop().ToString());
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && Prec(stack.Peek()) >= Prec(token[0]))
                            output.Enqueue(stack.Pop().ToString());
                        stack.Push(token[0]);
                    }
                }
            }

            while (stack.Count > 0)
                output.Enqueue(stack.Pop().ToString());

            return string.Join(" ", output);
        }

        private static double Calculate(string postfix)
        {
            var stack = new Stack<double>();
            var tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (token.Length == 1 && IsOperator(token[0]))
                {
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();
                    stack.Push(ApplyOperator(op1, token[0], op2));
                }
                else
                {
                    stack.Push(Convert.ToDouble(token, CultureInfo.InvariantCulture));
                }
            }
            return stack.Peek();
        }

        private static double ApplyOperator(double a, char op, double b)
        {
            return op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                '^' => Math.Pow(a, b),
                _ => throw new ArgumentException("Operador inválido")
            };
        }

        private static int Prec(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                '^' => 3,
                _ => 0
            };
        }

        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '(' || c == ')';
        }
    }
}
