public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        int[] primes = [2, 3, 5, 7, 11, 13, 17, 19];
        int result = 0;

        for (int i = left; i <= right; i++)
        {
            int setBits = BitOperations.PopCount((uint)i);
            if (primes.Contains(setBits))
            {
                result++;
            }
        }

        return result;
    }
}
