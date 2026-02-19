public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        int bit = n & 1;

        while (n != 0)
        {
            n >>= 1;
            if ((n & 1) == bit)
            {
                return false;
            }

            bit = n & 1;
        }

        return true;
    }
}
