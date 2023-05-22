// Given a positive integer n, find the sum of all integers in the range [1, n] inclusive that are divisible by 3, 5, or 7.

// Return an integer denoting the sum of all numbers in the given range satisfying the constraint.

public class Solution {
    public int SumOfMultiples(int n) {
        
        return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0).Sum();
    }
}