// Given a 0-indexed 2D grid of size m x n, you should find the matrix answer of size m x n.

// The value of each cell (r, c) of the matrix answer is calculated in the following way:

// Let topLeft[r][c] be the number of distinct values in the top-left diagonal of the cell (r, c) in the matrix grid.
// Let bottomRight[r][c] be the number of distinct values in the bottom-right diagonal of the cell (r, c) in the matrix grid.
// Then answer[r][c] = |topLeft[r][c] - bottomRight[r][c]|.

// Return the matrix answer.

// A matrix diagonal is a diagonal line of cells starting from some cell in either the topmost row or leftmost column and going in the bottom-right direction until reaching the matrix's end.

// A cell (r1, c1) belongs to the top-left diagonal of the cell (r, c), if both belong to the same diagonal and r1 < r. Similarly is defined bottom-right diagonal.

public class Solution {
    public int[][] DifferenceOfDistinctValues(int[][] grid) {
        
        var result = new int[grid.Length][];
        int leftDist;
        int rightDist;
        var h = new HashSet<int>();
        int x;
    
        for (int i = 0; i < grid.Length; i++)
        {
            result[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++)
            {
                leftDist = 0;
                rightDist = 0;
            
                if (i > 0 && j > 0)
                {
                    h.Clear();
                    x = 1;
                    while(i - x >= 0 && j - x >= 0)
                    {
                        h.Add(grid[i - x][j - x]);
                        x++;
                    }
                    leftDist = h.Count();
                }
            
                if (i < grid.Length - 1 && j < grid[i].Length - 1)
                {
                    h.Clear();
                    x = 1;
                    while (i + x < grid.Length && j + x < grid[i].Length)
                    {
                        h.Add(grid[i + x][j + x]);
                        x++;
                    }
                    rightDist = h.Count();
                }

                result[i][j] = Math.Abs(leftDist - rightDist);
            }    
        }

        return result;
    }
}