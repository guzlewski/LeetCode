public class Solution
{
    public int[] ConstructTransformedArray(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[(((i + nums[i]) % nums.Length) + nums.Length) % nums.Length];
        }

        return result;
    }
}
