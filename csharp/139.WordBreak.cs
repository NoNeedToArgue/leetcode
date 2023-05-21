// Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

// Note that the same word in the dictionary may be reused multiple times in the segmentation.

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        
        int n = wordDict.Count();
        bool gotIt;

        for (var i = 0; i < n; i++)
        {
            if (s.Contains(wordDict[i]))
            {
                string[] spl = s.Split(wordDict[i]);
                gotIt = true;
                foreach (string s2 in spl)
                {
                    if (s2.Length > 0)
                    {
                        if (!WordBreak(s2, wordDict))
                            gotIt = false;
                    }
                }
                
                if (gotIt)
                    return true;
            }
        }

        return false;
    }
}