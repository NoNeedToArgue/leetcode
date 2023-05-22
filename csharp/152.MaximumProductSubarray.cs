// Given an integer array nums, find a subarray that has the largest product, and return the product.

// The test cases are generated so that the answer will fit in a 32-bit integer.

public class Solution {
    public int MaxProduct(int[] nums) {

        int maxProd = nums[0];
        int curLeft = 1;
        int curRight = 1;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            curLeft = (curLeft == 0 ? 1 : curLeft) * nums[i];
            curRight = (curRight == 0 ? 1 : curRight) * nums[n - i - 1];
            maxProd = Math.Max(maxProd, Math.Max(curLeft, curRight));
        }
        
        return maxProd;
    }
}