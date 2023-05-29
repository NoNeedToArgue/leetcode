// You are given two 0-indexed integer arrays nums and divisors.

// The divisibility score of divisors[i] is the number of indices j such that nums[j] is divisible by divisors[i].

// Return the integer divisors[i] with the maximum divisibility score. If there is more than one integer with the maximum score, return the minimum of them.

public class Solution {
    public int MaxDivScore(int[] nums, int[] divisors) {
        
        int maxRes = 0;
        
        for (int i = 0; i < divisors.Length; i++)
        {
            var curRes = 0;
            
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] % divisors[i] == 0)
                {
                    curRes++;
                }
                else if (nums.Length - j + curRes - 1 < maxRes)
                {
                    break;
                }
            }
            
            if (i > 0)
            {
                if (curRes > maxRes)
                {
                    maxRes = curRes;
                }
                else if (curRes == maxRes)
                {
                    divisors[i] = Math.Min(divisors[i], divisors[i - 1]);
                }
                else
                {
                    divisors[i] = divisors[i - 1];
                }
            }
            else
            {
                maxRes = curRes;
            }
        }
        
        return divisors[divisors.Length - 1];
    }
}