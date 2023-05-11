// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int n = t.Length;
        if (n == 0 || s.Length == 0)
            return n >= s.Length;

        Stack<char> stack = new Stack<char>(s.ToCharArray().Reverse());

        for (var i = 0; i < n; i++)
        {
            if (t[i] == stack.Peek())
            {
                stack.Pop();
                if (stack.Count == 0)
                    break;
            }
        }
    
        return stack.Count == 0;
    }
}