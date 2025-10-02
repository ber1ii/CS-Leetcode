public class Solution
{
    public bool ValidParentheses(string s)
    {
        Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        List<char> stack = new List<char>();

        foreach (char c in s)
        {
            if (pairs.ContainsKey(c))
            {
                char top = (stack.Count > 0) ? stack[stack.Count - 1] : '#';

                stack.RemoveAt(stack.Count - 1);

                if (top != pairs[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Add(c);
            }
        }

        return stack.Count == 0;
    }
}