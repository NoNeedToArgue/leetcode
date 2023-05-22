// You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].

// Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at nums[i], you can jump to any nums[i + j] where:

// 0 <= j <= nums[i] and
// i + j < n
// Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].

public class Solution {
    public int Jump(int[] nums) {
        
        int n = nums.Length;
        if (n < 3)
            return n - 1;

        int steps = 0;
        int minIndex = 0;
        int maxIndex = 0;
        int tmp = 0;
        
        while (maxIndex < n - 1)
        {
            tmp = maxIndex;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                tmp = Math.Max(tmp, i + nums[i]);
            }
            minIndex = maxIndex;
            maxIndex = tmp;
            steps++;
        }
        
        return steps;
    }
}