// Given a m x n matrix mat and an integer k, return a matrix answer where each answer[i][j] is the sum of all elements mat[r][c] for:

// i - k <= r <= i + k,
// j - k <= c <= j + k, and
// (r, c) is a valid position in the matrix.

public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int k) {
        
        int m = mat.Length;
        int n = mat[0].Length;

        var dp = new int[m][];

        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                Summ(mat, dp, i, j, k);
            }
        }

        return dp;
    }

    private void Summ(int[][] mat, int[][] dp, int i, int j, int k)
    {
        int startRow = i - k > 0 ? i - k : 0;
        int endRow = i + k < mat.Length ? i + k : mat.Length - 1;
        int startCol = j - k > 0 ? j - k : 0;
        int endCol = j + k < mat[0].Length ? j + k : mat[0].Length - 1;

        for (var iRow = startRow; iRow <= endRow; iRow++)
        {
            for (var jCol = startCol; jCol <= endCol; jCol++)
            {
                dp[i][j] += mat[iRow][jCol];
            }
        }
    }
}