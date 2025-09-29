public class GroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

        foreach (string s in strs)
        {
            int[] counts = new int[26];

            foreach (char c in s)
            {
                counts[c - 'a']++;
            }

            StringBuilder keyBuilder = new StringBuilder();

            for (int i = 0; i < 26; i++)
            {
                keyBuilder.Append(counts[i]);
                keyBuilder.Append("#");
            }

            string key = keyBuilder.ToString();

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return new List<IList<string>>(map.Values);
    }
}