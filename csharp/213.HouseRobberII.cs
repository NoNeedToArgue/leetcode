// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

public class Solution {
    public int Rob(int[] nums) {

        int n = nums.Length;

        if (n < 4)
            return nums.Max();

        return Math.Max(MaxForRange(nums, 0, n - 1), MaxForRange(nums, 1, n));

        static int MaxForRange(int[] nums, int s, int e)
        {
            int prev1 = 0;
            int prev2 = 0;

            for (int i = s; i < e; i++)
            {
                int tmp = prev1;
                prev1 = Math.Max(nums[i] + prev2, prev1);
                prev2 = tmp;
            }

            return prev1;
        }
    }
}