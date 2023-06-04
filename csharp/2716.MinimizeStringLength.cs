// Given a 0-indexed string s, repeatedly perform the following operation any number of times:

// Choose an index i in the string, and let c be the character in position i. Delete the closest occurrence of c to the left of i (if any) and the closest occurrence of c to the right of i (if any).
// Your task is to minimize the length of s by performing the above operation any number of times.

// Return an integer denoting the length of the minimized string.

public class Solution {
    public int MinimizedStringLength(string s) {
        var sb = new StringBuilder(s);

        int changes;

        if (sb.Length > 1)
        {
            do
            {
                changes = sb.Length;

                for (var i = 1; i < sb.Length; i++)
                {
                    for (var j = i - 1; j >= 0; j--)
                    {
                        if (sb[j] == sb[i])
                        {
                            sb.Remove(j, 1);
                            break;
                        }
                    }

                    if (i < sb.Length - 1)
                    {
                        for (var j = i + 1; j < sb.Length; j++)
                        {
                            if (sb[j] == sb[i])
                            {
                                sb.Remove(j, 1);
                                break;
                            }
                        }
                    }
                }
            }
            while (changes > sb.Length);
        }

        return sb.Length;
    }
}