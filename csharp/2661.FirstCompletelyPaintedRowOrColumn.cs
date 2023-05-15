// You are given a 0-indexed integer array arr, and an m x n integer matrix mat. arr and mat both contain all the integers in the range [1, m * n].

// Go through each index i in arr starting from index 0 and paint the cell in mat containing the integer arr[i].

// Return the smallest index i at which either a row or a column will be completely painted in mat.

public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        
        int a = arr.Length;
        int m = mat.Length;
        int n = mat[0].Length;

        var rows = new int[m];
        var cols = new int[n];

        int x = 0;

        while (x < a)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[x] == mat[i][j])
                    {
                        rows[i]++;
                        cols[j]++;

                        if (rows[i] == n || cols[j] == m)
                            return x;

                        x++;
                    }
                }
            }
        }
    
        return 0;
    }
}