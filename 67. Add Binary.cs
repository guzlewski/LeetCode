public class Solution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder sb = new();
        int index = 0, carry = 0;

        while (index < a.Length || index < b.Length || carry > 0)
        {
            int sum = carry;
            sum += index < a.Length ? a[a.Length - 1 - index] - '0' : 0;
            sum += index < b.Length ? b[b.Length - 1 - index] - '0' : 0;

            sb.Append((char)((sum % 2) + '0'));
            carry = sum / 2;
            index++;
        }

        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
