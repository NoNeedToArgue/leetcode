// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.

// Note: You can only move either down or right at any point in time.

public class Solution {
    public int MinPathSum(int[][] grid) {
        
        int m = grid.Length;
        int n = grid[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                grid[i][j] += (i, j) switch
                {
                    (0, 0) => 0,
                    (0, _) => grid[i][j - 1],
                    (_, 0) => grid[i - 1][j],
                    _ => Math.Min(grid[i][j - 1], grid[i - 1][j])
                };
            }
        }

        return grid[^1][^1];
    }
}