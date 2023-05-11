// Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

// You have the following three operations permitted on a word:

// Insert a character
// Delete a character
// Replace a character

public class Solution {
    public int MinDistance(string word1, string word2) {
        
        int n1 = word1.Length;
        int n2 = word2.Length;

        var dp = new int[n1 + 1, n2 + 1];

        for (var i = 0; i <= n1; i++)
        {
            for (var j = 0; j <= n2; j++)
            {
                dp[i, j] = (i, j) switch
                {
                    (0, _) => j,
                    (_, 0) => i,
                    (_, _) => word1[i - 1] == word2[j - 1] ?
                              dp[i - 1, j - 1] :
                              1 + Math.Min(dp[i - 1, j - 1],
                                Math.Min(dp[i, j - 1], dp[i - 1, j]))
                };
            }
        }

        return dp[n1, n2];
    }
}