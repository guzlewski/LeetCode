public class Solution
{
    public bool IsTrionic(int[] nums)
    {
        int index = 0;
        bool[] segments = [false, false, false];

        while (index < nums.Length - 3 && nums[index] < nums[index + 1])
        {
            segments[0] = true;
            index++;
        }

        while (index < nums.Length - 2 && nums[index] > nums[index + 1])
        {
            segments[1] = true;
            index++;
        }

        while (index < nums.Length - 1 && nums[index] < nums[index + 1])
        {
            segments[2] = true;
            index++;
        }

        return index == nums.Length - 1 && segments[0] && segments[1] && segments[2];
    }
}
