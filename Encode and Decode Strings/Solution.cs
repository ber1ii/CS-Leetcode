public class Solution
{
    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string s in strs)
        {
            sb.Append(s.Length).Append("#");
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> res = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++; // Get the position of delimiter #
            }

            //We get length of current snippet by doing Substring
            //from i to j - i, because j is the position of #
            //and i is the starting position, so to access the
            //number we placed before a delimiter and parse it to integer
            int length = int.Parse(s.Substring(i, j - i));

            //The actual string starts at j+1
            string str = s.Substring(j + 1, length);
            res.Add(str);

            //move to the next segment
            i = j + 1 + length;
        }

        return res;
    }
}