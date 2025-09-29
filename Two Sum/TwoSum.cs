public class TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            indices[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (indices.ContainsKey(complement) && indices[complement] != i)
            {
                return new int[] { i, indices[complement] };
            }
        }

        return Array.Empty<int>();
    }
}