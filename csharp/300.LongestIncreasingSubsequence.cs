// Given an integer array nums, return the length of the longest strictly increasing subsequence.
// A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.

public class Solution {
    public int LengthOfLIS(int[] nums) {

        List<int> list = new();
        list.Add(nums[0]);

        foreach(int i in nums)
        {
            if (i > list[list.Count - 1])
            {
                list.Add(i);
            }
            else
            {
                int pos = list.BinarySearch(i);
                if (pos < 0)
                {
                    list[~pos] = i;
                }
            }
        }

        return list.Count;
    }
}