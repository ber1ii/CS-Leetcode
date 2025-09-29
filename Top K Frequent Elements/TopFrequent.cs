public class TopFrequent {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
            }
            freq[num]++;
        }

        int n = nums.Length;
        List<int>[] buckets = new List<int>[n + 1];

        foreach (var kv in freq)
        {
            int number = kv.Key;
            int count = kv.Value;

            if (buckets[count] == null)
            {
                buckets[count] = new List<int>();
            }
            buckets[count].Add(number);
        }

        List<int> result = new List<int>();

        for (int i = n; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.Take(k).ToArray();
    }
}