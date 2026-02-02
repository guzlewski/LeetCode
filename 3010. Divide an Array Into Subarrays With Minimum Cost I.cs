public class Solution
{
    public int MinimumCost(int[] nums)
    {
        int[] cost = [nums[0], Math.Max(nums[1], nums[2]), Math.Min(nums[1], nums[2])];

        for (int i = 3; i < nums.Length; i++)
        {
            if (nums[i] <= cost[2])
            {
                cost[1] = cost[2];
                cost[2] = nums[i];
            }
            else if (nums[i] < cost[1])
            {
                cost[1] = nums[i];
            }
        }

        return cost.Sum();
    }
}
