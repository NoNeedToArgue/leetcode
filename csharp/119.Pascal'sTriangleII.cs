// Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        var result = new int[rowIndex + 1];
        result[0] = 1;
        result[^1] = 1;

        for (var i = 1; i <= rowIndex / 2; i++)
        {
            result[i] = (int)((long)result[i - 1] * (rowIndex + 1 - i) / i);
            result[^(i + 1)] = result[i];
        }

        return result;
    }
}