// You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

// Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

public class Solution {
    public double Average(int[] salary) {
        
        double sum = salary.
            Select(x => x != salary.Max() && x != salary.Min() ? x : 0).Sum();

        return sum / (salary.Length - 2);
    }
}