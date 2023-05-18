// Given an integer numRows, return the first numRows of Pascal's triangle.

// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        var result = new List<IList<int>>();

        for (var i = 1; i <= numRows; i++)
        {
            var curList = new List<int>();
            for (var j = 1; j <= i; j++)
            {
                if (j == 1 || j == i)
                {
                    curList.Add(1);
                }
                else
                {
                    curList.Add(result[i - 2][j - 2] + result[i - 2][j - 1]);
                }
            }

            result.Add(curList);
        }

        return result;
    }
}