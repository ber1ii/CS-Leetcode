using System.Collections.Generic;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int prevIdx = stack.Pop();
                result[prevIdx] = i - prevIdx;
            }

            stack.Push(i);
        }

        return result; 
    }
}