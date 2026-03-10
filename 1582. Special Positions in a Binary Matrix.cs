public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        int[] rows = new int[mat.Length];
        for (int i = 0; i < mat.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                sum += mat[i][j];
            }

            rows[i] = sum;
        }

        int[] columns = new int[mat[0].Length];
        for (int j = 0; j < mat[0].Length; j++)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][j];
            }

            columns[j] = sum;
        }

        int special = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1 && rows[i] == 1 && columns[j] == 1)
                {
                    special++;
                }
            }
        }

        return special;
    }
}
