public class Solution
{
    public int LongestBalanced(int[] nums)
    {
        int longest = 0;

        for (int start = 0; start < nums.Length; start++)
        {
            HashSet<int> even = [], odd = [];

            for (int end = start; end < nums.Length; end++)
            {
                if (nums[end] % 2 == 0)
                {
                    even.Add(nums[end]);
                }
                else
                {
                    odd.Add(nums[end]);
                }

                if (even.Count == odd.Count)
                {
                    longest = Math.Max(longest, end - start + 1);
                }
            }
        }

        return longest;
    }
}