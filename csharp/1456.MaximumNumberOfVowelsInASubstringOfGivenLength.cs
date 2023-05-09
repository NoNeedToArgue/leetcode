// Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

// Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

public class Solution {
    public int MaxVowels(string s, int k) {

        int n = s.Length;
        int result = 0;
        int current = 0;

        for (var i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
            {
                current++;
            }
        }

        result = current;

        for (var i = k; i < n; i++)
        {
            if (IsVowel(s[i - k]))
            {
                current--;
            }
            if (IsVowel(s[i]))
            {
                current++;
            }
            result = Math.Max(result, current);
        }

        return result;
    }

    public bool IsVowel(char c)
    {
        return c == 'a' || c == 'e'|| c == 'i' || c == 'o' || c == 'u';
    }
}