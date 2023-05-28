// Given a positive integer num represented as a string, return the integer num without trailing zeros as a string.

public class Solution {
    public string RemoveTrailingZeros(string num) {
        
        var sb = new StringBuilder();
        int n = num.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (sb.Length == 0)
            {
                if (num[i] != '0')
                    sb.Append(num[i]);
            }
            else
            {
                sb.Append(num[i]);
            }    
        }

        var result = sb.ToString().ToCharArray();

        Array.Reverse(result);

        return new string(result);
    }
}