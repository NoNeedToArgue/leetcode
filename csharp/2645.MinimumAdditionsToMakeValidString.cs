// Given a string word to which you can insert letters "a", "b" or "c" anywhere and any number of times, return the minimum number of letters that must be inserted so that word becomes valid.

// A string is called valid if it can be formed by concatenating the string "abc" several times.

public class Solution {
    public int AddMinimum(string word) {
    
        var res = 0;

        var cost = new Dictionary<(char, char), int>();
        cost.Add(('a', 'b'), 1);
        cost.Add(('a', 'c'), 2);
        cost.Add(('b', 'c'), 1);
        cost.Add(('b', 'a'), 2);
        cost.Add(('c', 'a'), 1);
        cost.Add(('c', 'b'), 2);

        var next = new Dictionary<char, char>();
        next.Add('a', 'b');
        next.Add('b', 'c');
        next.Add('c', 'a');

        char expected = 'a';

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != expected)
            {
                res += cost[(expected, word[i])];
            }
            expected = next[word[i]];
        }

        if (expected == 'b')
        {
            res += 2;
        }
        else if (expected == 'c')
        {
            res += 1;
        }

        return res;
    }
}