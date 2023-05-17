// In a linked list of size n, where n is even, the ith node (0-indexed) of the linked list is known as the twin of the (n-1-i)th node, if 0 <= i <= (n / 2) - 1.

// For example, if n = 4, then node 0 is the twin of node 3, and node 1 is the twin of node 2. These are the only nodes with twins for n = 4.
// The twin sum is defined as the sum of a node and its twin.

// Given the head of a linked list with even length, return the maximum twin sum of the linked list.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        
        List<int> list = new();
        int maxSum = 0;
 
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        int n = list.Count / 2;
        
        for (var i = 0;  i < n; i++)
        {
            if (list[i] + list[^(i + 1)] > maxSum)
            {
                maxSum = list[i] + list[^(i + 1)];
            }
        }

        return maxSum;
    }
}