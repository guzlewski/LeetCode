public class Solution
{
    public int BitwiseComplement(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        int leadingZeros = BitOperations.LeadingZeroCount((uint)n);
        int mask = (1 << ((sizeof(int) * 8) - leadingZeros)) - 1;

        return n ^ mask;
    }
}
