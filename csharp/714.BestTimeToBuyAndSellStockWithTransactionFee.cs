// You are given an array prices where prices[i] is the price of a given stock on the ith day, and an integer fee representing a transaction fee.

// Find the maximum profit you can achieve. You may complete as many transactions as you like, but you need to pay the transaction fee for each transaction.

// Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        
        int n = prices.Length;
        
        if (n < 2)
            return 0;

        var sell = new int[n];
        var buy = new int[n];

        sell[0] = 0;
        buy[0] = 0 - prices[0];

        for (var i = 1; i < n; i++)
        {
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
            buy[i] = Math.Max(buy[i - 1], sell[i] - prices[i]);
        }
        
        return sell[n - 1];
    }
}