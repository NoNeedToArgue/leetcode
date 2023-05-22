// Given an array of integers nums, find the maximum length of a subarray where the product of all its elements is positive.

// A subarray of an array is a consecutive sequence of zero or more values taken out of that array.

// Return the maximum length of a subarray with positive product.

public class Solution {
    public int GetMaxLen(int[] nums) {
        
        int maxLen = 0;
        int rangePos = 0;
        int rangeNeg = 0;
        int tmp = 0;

        foreach (int i in nums)
        {
            switch (i)
            {
                case 0:
                    rangePos = 0;
                    rangeNeg = 0;
                    break;
                case > 0:
                    rangePos++;
                    rangeNeg = rangeNeg == 0 ? 0 : rangeNeg + 1;
                    break;
                default:
                    tmp = rangePos;
                    rangePos = rangeNeg == 0 ? 0 : rangeNeg + 1;
                    rangeNeg = tmp + 1;
                    break;
            }

            maxLen = Math.Max(maxLen, rangePos);
        }

        return maxLen;
    }
}