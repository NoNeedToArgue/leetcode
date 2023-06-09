// Given an n x n array of integers matrix, return the minimum sum of any falling path through matrix.

// A falling path starts at any element in the first row and chooses the element in the next row that is either directly below or diagonally left/right. Specifically, the next element from position (row, col) will be (row + 1, col - 1), (row + 1, col), or (row + 1, col + 1).

public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        
        int n = matrix.Length;

        for (var i = n - 2; i >= 0; i--)
        {
            for (var j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrix[i][j] = Math.Min(matrix[i][j] + matrix[i + 1][j],
                        matrix[i][j] + matrix[i + 1][j + 1]);
                }
                else if (j == n - 1)
                {
                    matrix[i][j] = Math.Min(matrix[i][j] + matrix[i + 1][j],
                        matrix[i][j] + matrix[i + 1][j - 1]);
                }
                else
                {
                    matrix[i][j] = Math.Min(matrix[i][j] + matrix[i + 1][j - 1],
                        Math.Min(matrix[i][j] + matrix[i + 1][j],
                        matrix[i][j] + matrix[i + 1][j + 1]));
                }
            }
        }

        return matrix[0].Min();        
    }
}