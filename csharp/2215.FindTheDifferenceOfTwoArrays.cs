// Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

// answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
// answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
// Note that the integers in the lists may be returned in any order.

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {

        IList<IList<int>> result = new List<IList<int>>();

        List<int> diff1 = nums1.Except(nums2).ToList();
        List<int> diff2 = nums2.Except(nums1).ToList();

        result.Add(diff1);
        result.Add(diff2);

       return result;
    }
}