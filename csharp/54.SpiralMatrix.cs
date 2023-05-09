// Given an m x n matrix, return all elements of the matrix in spiral order.

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        int l = m * n;
        List<int> result = new();
        int level = 0;
                
        while (result.Count < l)
        {

            for (var j = level; j < n - level; j++)
            {   
                result.Add(matrix[level][j]);
            }

            for (var i = level + 1; i < m - level; i++)
            {
                result.Add(matrix[i][n - level - 1]);
            }

            if (result.Count == l)
            {
                break;
            }

            for (var j = n - level - 2; j >= level; j--)
            {
                result.Add(matrix[m - level - 1][j]);
            }
            
            for (var i = m - level - 2; i >= 1 + level; i--)
            {
                result.Add((matrix[i][level]));
            }

            level++;
        }

        return result;
    }
}