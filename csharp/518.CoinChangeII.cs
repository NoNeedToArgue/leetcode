// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

// Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.

// You may assume that you have an infinite number of each kind of coin.

// The answer is guaranteed to fit into a signed 32-bit integer.

public class Solution {
    public int Change(int amount, int[] coins) {
        
        var dp = new int[amount + 1];
        dp[0] = 1;

        foreach (int coin in coins)
        {
            for (var i = coin; i <= amount; i++)
            {
                dp[i] += dp[i - coin];
            }
        }
        
        return dp[amount];
    }
}