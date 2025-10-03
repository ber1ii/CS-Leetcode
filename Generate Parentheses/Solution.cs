public class Solution
{
    public List<string> GenerateParentheses(int n)
    {
        List<string> res = new List<string>();
        Backtrack(res, new StringBuilder(), 0, 0, n);
        return res;
    }

    private void Backtrack(List<string> res, StringBuilder current, int open, int close, int max)
    {
        if (current.Length == max * 2)
        {
            res.Add(current.ToString());
            return;
        }

        if (open < max)
        {
            current.Append('(');
            Backtrack(res, current, open + 1, close, max);
            current.Length--;
        }

        if (close < open)
        {
            current.Append(")");
            Backtrack(res, current, open, close + 1, max);
            current.Length--;
        }
    }
}