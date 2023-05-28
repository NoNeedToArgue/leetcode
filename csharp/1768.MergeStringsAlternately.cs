// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

// Return the merged string.

public class Solution {
    public string MergeAlternately(string word1, string word2) {

        int l1 = word1.Length;
        int l2 = word2.Length;
        int n = Math.Min(l1, l2);
        string res = "";

        for (int i = 0; i < n; i++)
        {
            res += word1[i];
            res += word2[i];
        }

        if (l1 == l2)
            return res;

        return l1 > l2 ? res + word1.Substring(l2, l1 - l2)
            : res + word2.Substring(l1, l2 - l1);
    }
}