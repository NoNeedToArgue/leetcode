// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

// Return the array in the form [x1,y1,x2,y2,...,xn,yn].

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        
        int[] result = new int[2*n];

        for (int i = 0, j = 0; i < n; i++, j++)
        {
            result[j] = nums[i];
            j++;
            result[j] = nums[i + n];            
        }

        return result;

    }
}