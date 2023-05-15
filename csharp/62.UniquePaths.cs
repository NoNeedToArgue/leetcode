// There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

// The test cases are generated so that the answer will be less than or equal to 2 * 109.

public class Solution {
    public int UniquePaths(int m, int n) {
        
        var dp = new int[m + 1, n + 1];
        dp[1, 0] = 1;

        for (var i = 1; i <= m; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                dp[i, j] = dp [i - 1, j] + dp [i, j - 1];
            }
        }
        
        return dp[m, n];
    }
}