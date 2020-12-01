using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    class Program
    {
        static string isBalanced(string s)
        {
            string isBalanced = string.Empty;

            bool correctInput = IsCorrectInput(s);

            if (correctInput)
            {
                isBalanced = "YES";
            }
            else
            {
                isBalanced = "NO";
            }

            return isBalanced;
        }

        private static bool IsCorrectInput(string input)
        {
            if (!IsClosedBracket(input.Last()))
            {
                return false;
            }

            Stack<char> brackets = new Stack<char>();
            bool isCorrectInput = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (IsOpenedBracket(input[i]))
                {
                    brackets.Push(input[i]);
                }
                else if (IsClosedBracket(input[i]))
                {
                    int minStackLength = 1;

                    if (brackets.Count < minStackLength)
                    {
                        isCorrectInput = false;
                        break;
                    }

                    var previousOpened = brackets.Pop();

                    if (!IsBracketsMatched(previousOpened, input[i]))
                    {
                        isCorrectInput = false;
                        break;
                    }
                }
                else
                {
                    isCorrectInput = false;
                    break;
                }
            }

            return isCorrectInput;
        }

        private static bool IsBracketsMatched(char openedBracket, char currentBracket)
        {
            if (openedBracket == '[' && currentBracket == ']')
            {
                return true;
            }
            else if (openedBracket == '(' && currentBracket == ')')
            {
                return true;
            }
            if (openedBracket == '{' && currentBracket == '}')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOpenedBracket(char bracket)
        {
            return bracket == '[' || bracket == '{' || bracket == '(';
        }

        private static bool IsClosedBracket(char bracket)
        {
            return bracket == ']' || bracket == '}' || bracket == ')';
        }

        static void Main(string[] args)
        {
            string example = "[{";
            string res = isBalanced(example);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
