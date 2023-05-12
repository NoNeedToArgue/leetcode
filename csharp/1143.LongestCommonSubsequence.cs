// Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

// A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

// For example, "ace" is a subsequence of "abcde".
// A common subsequence of two strings is a subsequence that is common to both strings.

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        int n1 = text1.Length;
        int n2 = text2.Length;
        var dp = new int[n1 + 1, n2 + 1];

        for (var i = 1; i <= n1; i++)
        {
            for (var j = 1; j <= n2; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        return dp[n1, n2];
    }
}