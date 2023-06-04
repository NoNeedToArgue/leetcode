// You are given an integer n and a 0-indexed 2D array queries where queries[i] = [typei, indexi, vali].

// Initially, there is a 0-indexed n x n matrix filled with 0's. For each query, you must apply one of the following changes:

// if typei == 0, set the values in the row with indexi to vali, overwriting any previous values.
// if typei == 1, set the values in the column with indexi to vali, overwriting any previous values.
// Return the sum of integers in the matrix after all queries are applied.

public class Solution {
    public long MatrixSumQueries(int n, int[][] queries) {
        
        int rows = 0;
        int columns = 0;
        long result = 0;

        var mem = new HashSet<(int, int)>();

        for (var i = queries.Length - 1; i >= 0; i--)
        {
            if (mem.Contains((queries[i][0], queries[i][1])))
                continue;

            if (queries[i][0] == 0)
            {
                result += queries[i][2] * (n - columns);
                rows++;
                mem.Add((queries[i][0], queries[i][1]));
            }
            else
            {
                result += queries[i][2] * (n - rows);
                columns++;
                mem.Add((queries[i][0], queries[i][1]));
            }

            if (rows == n || columns == n || rows + columns == n + n - 1)
                break;
        }

        return result;
    }
}