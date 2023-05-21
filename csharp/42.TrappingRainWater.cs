// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

public class Solution {
    public int Trap(int[] height) {
        
        int n = height.Length;
        var result = 0;
        var left = new int[n];
        var right = new int[n];

        left[0] = height[0];
        for (var i = 1; i < n; i++)
        {
            left[i] = Math.Max(left[i - 1], height[i]);
        }

        right[n - 1] = height[n - 1];
        for (var i = n - 2; i >= 0; i--)
        {
            right[i] = Math.Max(right[i + 1], height[i]);
        }

        for (var i = 1; i < n - 1; i++)
        {
            result += Math.Min(left[i], right[i]) - height[i];
        }

        return result;
    }
}