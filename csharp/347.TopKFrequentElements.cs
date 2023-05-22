// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var result = new int[k];
        var dict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        var sortedDict = dict.OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        int i = 0;
        foreach (var num in sortedDict)
        {
            result[i++] = num.Key;
            if (i == k) break;
        }

        return result;
    }
}