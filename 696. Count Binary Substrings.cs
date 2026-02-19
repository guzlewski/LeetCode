public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        List<int> groups = [];
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[start])
            {
                groups.Add(i - start);
                start = i;
            }
        }

        groups.Add(s.Length - start);
        int result = 0;

        for (int i = 0; i < groups.Count - 1; i++)
        {
            result += Math.Min(groups[i], groups[i + 1]);
        }

        return result;
    }
}