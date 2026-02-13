public class Solution
{
    public int LongestBalanced(string s)
    {
        int longest = 0;

        for (int start = 0; start < s.Length; start++)
        {
            int frequent = 0, unique = 0;
            int[] letters = new int[26];

            for (int end = start; end < s.Length; end++)
            {
                int index = s[end] - 'a';
                letters[index]++;
                frequent = Math.Max(frequent, letters[index]);

                if (letters[index] == 1)
                {
                    unique++;
                }

                if (frequent * unique == end - start + 1)
                {
                    longest = Math.Max(longest, end - start + 1);
                }
            }
        }

        return longest;
    }
}
