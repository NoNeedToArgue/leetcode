// Given a 2D matrix matrix, handle multiple queries of the following type:

// Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
// Implement the NumMatrix class:

// NumMatrix(int[][] matrix) Initializes the object with the integer matrix matrix.
// int sumRegion(int row1, int col1, int row2, int col2) Returns the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
// You must design an algorithm where sumRegion works on O(1) time complexity.

public class NumMatrix {

    private int[][] _matrix;

    public NumMatrix(int[][] matrix) {

        int m = matrix.Length;
        int n = matrix[0].Length;

        _matrix = new int[m][];

        for (var i = 0; i < m; i++)
        {
            _matrix[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                _matrix[i][j] = matrix[i][j] + (j > 0 ? _matrix[i][j - 1] : 0);
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                _matrix[i][j] += i > 0 ? _matrix[i - 1][j] : 0;
            }
        }

    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        
        return _matrix[row2][col2] - (row1 > 0 ? _matrix[row1 - 1][col2] : 0) -
            (col1 > 0 ? _matrix[row2][col1 - 1] : 0) +
            (row1 > 0 && col1 > 0 ? _matrix[row1 - 1][col1 - 1] : 0);
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */