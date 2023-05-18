// An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

// Given an integer n, return the nth ugly number.

public class Solution {
    public int NthUglyNumber(int n) {
        
        if (n == 1)
            return 1;

        var dp = new int[n];
        dp[0] = 1;
        
        var by2 = 0;
        var by3 = 0;
        var by5 = 0;

        for (var i = 1; i < n; i++)
        {
            dp[i] = Math.Min(dp[by2] * 2, Math.Min(dp[by3] * 3, dp[by5] * 5));
            if (dp[i] == dp[by2] * 2)
            {
                by2++;
            }
            if (dp[i] == dp[by3] * 3)
            {
                by3++;
            }
            if (dp[i] == dp[by5] * 5)
            {
                by5++;
            }
        }

        return dp[n - 1];
    }
}