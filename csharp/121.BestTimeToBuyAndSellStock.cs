// You are given an array prices where prices[i] is the price of a given stock on the ith day.

// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

public class Solution {
    public int MaxProfit(int[] prices) {
        
        int n = prices.Length;
        var maxProfit = 0;
        int minValue = prices[0];

        for (var i = 1; i < n; i++)
        {
            maxProfit = Math.Max(maxProfit, prices[i] - minValue);
            minValue = Math.Min(minValue, prices[i]);
        }

        return maxProfit;
    }
}