using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = "{[()]}";
        Stack<char> stack = new Stack<char>();
        bool isBalanced = true;

        foreach (char ch in expression)
        {
            if (ch == '{' || ch == '[' || ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == '}' || ch == ']' || ch == ')')
            {
                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                char last = stack.Pop();
                if (!((last == '{' && ch == '}') || (last == '[' && ch == ']') || (last == '(' && ch == ')')))
                {
                    isBalanced = false;
                    break;
                }
            }
        }

        if (stack.Count != 0)
        {
            isBalanced = false;
        }

        Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
    }
}
