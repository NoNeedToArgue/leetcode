// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

public class Solution {
    public int ClimbStairs(int n) {
        
       if (n <= 2)
       {
           return n;
       }

       int f = 1;
       int s = 2;
       int res = 0;

       for (int i = 2; i < n; i++)
       {
           res = f + s;
           f = s;
           s = res;
       }

       return s;

    }
}