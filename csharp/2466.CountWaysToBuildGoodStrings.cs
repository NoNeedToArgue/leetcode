// Given the integers zero, one, low, and high, we can construct a string by starting with an empty string, and then at each step perform either of the following:

// Append the character '0' zero times.
// Append the character '1' one times.
// This can be performed any number of times.

// A good string is a string constructed by the above process having a length between low and high (inclusive).

// Return the number of different good strings that can be constructed satisfying these properties. Since the answer can be large, return it modulo 109 + 7.

public class Solution {
    public int CountGoodStrings(int low, int high, int zero, int one) {

        int mod = 1000000007;
        int result = 0;
        var dp = new int[high + 1];
        dp[0] = 1;

        for (var i = 1; i <= high; i++)
        {
            if (i >= zero)
            {
                dp[i] += dp[i - zero];
            }
            
            if (i >= one)
            {
                dp[i] += dp[i - one];
            }

            dp[i] %= mod;

            if (i >= low)
            {
                result += dp[i];
                result %= mod;
            }
        }

        return result;
    }
}