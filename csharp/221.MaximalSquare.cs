// Given an m x n binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

public class Solution {
    public int MaximalSquare(char[][] matrix) {

        int m = matrix.Length;
        int n = matrix[0].Length;
        var dp = new int[m, n];
        int maxSquare = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (matrix[i][j] == '1')
                {
                    dp[i, j] = 1;
                    maxSquare = 1;
                }
            }
        }
        
        if (maxSquare == 0)
            return 0;

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                if (matrix[i - 1][j - 1] == '1' &&
                    matrix[i][j - 1] == '1' &&
                    matrix[i - 1][j] == '1' &&
                    matrix[i][j] == '1')
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1],
                            Math.Min(dp[i, j - 1], dp[i - 1, j])) + 1;
                        
                        maxSquare = Math.Max(maxSquare, dp[i, j]);
                    }
            }
        }

        return maxSquare * maxSquare;
    }
}