// Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

public class Solution {
    public int[][] GenerateMatrix(int n) {
        
        int resLen = n * n;
        
        var result = new int[n][];
        for (var i = 0; i < n; i++)
            result[i] = new int[n];
        
        int level = 0;
        int count = 1;
              
        while (count <= resLen)
        {

            for (var j = level; j < n - level; j++)
            {   
                result[level][j] = count++;
            }

            for (var i = level + 1; i < n - level; i++)
            {
                result[i][n - level - 1] = count++;
            }

            for (var j = n - level - 2; j >= level; j--)
            {
                result[n - level - 1][j] = count++;
            }
            
            for (var i = n - level - 2; i >= 1 + level; i--)
            {
                result[i][level] = count++;
            }

            level++;
        }

        return result;
     }
}