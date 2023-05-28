// You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

// You can either start from the step with index 0, or the step with index 1.

// Return the minimum cost to reach the top of the floor.

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        
        int n = cost.Length;
        var dp = new int[n + 1];
        dp[n] = 0;
        dp[n - 1] = cost[n - 1];

        for (int i = n - 2; i >= 0; i--)
        {
            dp[i] = cost[i] + Math.Min(dp[i + 1], dp[i + 2]);
        }

        return Math.Min(dp[0], dp[1]);

    }
}