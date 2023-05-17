// Given a triangle array, return the minimum path sum from top to bottom.

// For each step, you may move to an adjacent number of the row below. More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        
        int n = triangle.Count;
        
        for (var i = n - 2; i >= 0; i--)
        {
            for (var j = 0; j < i + 1; j++)
            {
                triangle[i][j] = Math.Min(triangle[i][j] + triangle[i + 1][j],
                    triangle[i][j] + triangle[i + 1][j + 1]);
            }
        }

        return triangle[0][0];
    }
}