// You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

// Return true if you can reach the last index, or false otherwise.

public class Solution {
    public bool CanJump(int[] nums) {
        
        int n = nums.Length;
        int cost = 1;
        
        for (int i = n-2; i >= 0; i--)
        {
            if (nums[i] < cost)
            {
                cost++;
            }
            else if (cost > 1)
            {
                cost = 1;
            }
        }

        return cost == 1 ? true : false;
    }
}