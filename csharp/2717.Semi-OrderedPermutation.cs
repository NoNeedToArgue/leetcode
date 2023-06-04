// You are given a 0-indexed permutation of n integers nums.

// A permutation is called semi-ordered if the first number equals 1 and the last number equals n. You can perform the below operation as many times as you want until you make nums a semi-ordered permutation:

// Pick two adjacent elements in nums, then swap them.
// Return the minimum number of operations to make nums a semi-ordered permutation.

// A permutation is a sequence of integers from 1 to n of length n containing each number exactly once.

public class Solution {
    public int SemiOrderedPermutation(int[] nums) {
        
        int n = nums.Length;
        int perm = 0;
        int temp;

        do
        {
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 1 && i > 0)
                {
                    temp = nums[i - 1];
                    nums[i - 1] = 1;
                    nums[i] = temp;
                    perm++;
                }

                if (nums[i] == n && i < n - 1)
                {
                    temp = nums[i + 1];
                    nums[i + 1] = n;
                    nums[i] = temp;
                    perm++;
                }
            }
        }
        while (nums[0] != 1 || nums[n - 1] != n);
        
        return perm;
    }
}