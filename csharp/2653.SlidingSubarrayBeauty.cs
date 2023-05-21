// Given an integer array nums containing n integers, find the beauty of each subarray of size k.

// The beauty of a subarray is the xth smallest integer in the subarray if it is negative, or 0 if there are fewer than x negative integers.

// Return an integer array containing n - k + 1 integers, which denote the beauty of the subarrays in order from the first index in the array.

// A subarray is a contiguous non-empty sequence of elements within an array.

public class Solution {
    public int[] GetSubarrayBeauty(int[] nums, int k, int x) {
        
        int n = nums.Length;
        var tmp = new List<int>();
        var res = new List<int>();

        for (var i = 0; i < k; i++)
        {
            tmp.Add(nums[i] <= 0 ? nums[i] : 0);
        }
        tmp.Sort();
        res.Add(tmp[x - 1]);

        var insertIndex = 0;

        for (var i = k; i < n; i++)
        {
            tmp.Remove(nums[i - k] < 0 ? nums[i - k] : 0);

            if (nums[i] >= 0)
            {
                tmp.Add(0);
            }
            else
            {
                insertIndex = tmp.BinarySearch(nums[i]);
                if (insertIndex < 0)
                    tmp.Insert(~insertIndex, nums[i]);
                else
                    tmp.Insert(insertIndex, nums[i]);
            }

            res.Add(tmp[x - 1]);
        }

    return res.ToArray();
    }
}