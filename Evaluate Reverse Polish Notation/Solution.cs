using System.Collections.Generic;
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string s in tokens)
        {
            if (int.TryParse(s, out int num))
            {
                stack.Push(num);
            }
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();
                int res = 0;

                switch (s)
                {
                    case "+": res = a + b; break;
                    case "-": res = a - b; break;
                    case "*": res = a * b; break;
                    case "/": res = a / b; break;
                }

                stack.Push(res);
            }
        }

        return stack.Pop();
    }
}