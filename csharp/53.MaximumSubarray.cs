// Given an integer array nums, find the subarray with the largest sum, and return its sum.

public class Solution {
    public int MaxSubArray(int[] nums) {

        int maxSum = nums[0];
        int sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum = Math.Max(nums[i], nums[i] + sum);

            maxSum = Math.Max(sum, maxSum);
        }

        return maxSum;
    }
}