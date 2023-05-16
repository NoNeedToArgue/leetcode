// You are given two 0-indexed integer permutations A and B of length n.

// A prefix common array of A and B is an array C such that C[i] is equal to the count of numbers that are present at or before the index i in both A and B.

// Return the prefix common array of A and B.

// A sequence of n integers is called a permutation if it contains all integers from 1 to n exactly once.

public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        
        int n = A.Length;
        Span<int> sA = A;
        Span<int> sB = B;
        var res = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Span<int> first = sA.Slice(0, i + 1);
            Span<int> second = sB.Slice(0, i + 1);
            res[i] = first.ToArray().Intersect(second.ToArray()).Count();
        }

        return res;
    }
}