public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            int countA = BitOperations.PopCount((uint)a);
            int countB = BitOperations.PopCount((uint)b);

            return countA != countB ? countA.CompareTo(countB) : a.CompareTo(b);
        });

        return arr;
    }
}
