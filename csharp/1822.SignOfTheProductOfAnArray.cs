// There is a function signFunc(x) that returns:

// 1 if x is positive.
// -1 if x is negative.
// 0 if x is equal to 0.
// You are given an integer array nums. Let product be the product of all values in the array nums.

// Return signFunc(product).

public class Solution {
    public int ArraySign(int[] nums) {
        
        if (nums.Contains(0))
        {
            return 0;
        }

        int negNums = nums.Where(x => x < 0).Count();
        
        return negNums % 2 == 0 ? 1 : -1;
    }
}