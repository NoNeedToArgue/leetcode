// Given a m x n binary matrix mat, find the 0-indexed position of the row that contains the maximum count of ones, and the number of ones in that row.

// In case there are multiple rows that have the maximum count of ones, the row with the smallest row number should be selected.

// Return an array containing the index of the row, and the number of ones in it.

public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        
        var result = new int[2];
        
        for (int i = 0; i < mat.Length; i++)
        {
            int curOnes = 0;

            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    curOnes++;
                }
                else if (mat[i].Length - j + curOnes - 1 <= result[1])
                {
                    break;
                }    
            }

            if (curOnes > result[1])
            {
                result[0] = i;
                result[1] = curOnes;
            }
   
            if (result[1] == mat[i].Length)
            {
                break;
            }
        }

        return result;
    }
}