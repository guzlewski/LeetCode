public class Solution
{
    public int BinaryGap(int n)
    {
        int previous = -1, current = -1, max = int.MinValue, i = 0;

        while (n != 0)
        {
            if ((n & 1) == 1)
            {
                previous = current;
                current = i;

                if (previous >= 0 && current >= 0)
                {
                    max = Math.Max(max, current - previous);
                }
            }

            n >>= 1;
            i++;
        }

        return max != int.MinValue ? max : 0;
    }
}
