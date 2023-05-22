// You are given an integer array nums. You want to maximize the number of points you get by performing the following operation any number of times:

// Pick any nums[i] and delete it to earn nums[i] points. Afterwards, you must delete every element equal to nums[i] - 1 and every element equal to nums[i] + 1.
// Return the maximum number of points you can earn by applying the above operation some number of times.

public class Solution {
    public int DeleteAndEarn(int[] nums) {
        
        int maxValue = 0;
        Dictionary<int, int> dp = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!dp.ContainsKey(num))
            {
                dp.Add(num, num);
                maxValue = Math.Max(maxValue, num);
            }
            else
            {
                dp[num] += num;
            }
        }

        int tmp = 0;
        int prev2 = 0;
        int prev1 = dp.ContainsKey(1) ? dp[1] : 0;
        
        for (int i = 2; i <= maxValue; i++)
        {
            tmp = prev1;
            prev1 = Math.Max(prev1, prev2 + (dp.ContainsKey(i) ? dp[i] : 0));
            prev2 = tmp;
        }

        return prev1;        
    }
}