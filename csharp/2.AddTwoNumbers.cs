// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        var result = new ListNode();
        var current = result;
        int dinm = 0;
        int summ = 0;

        while (l1 != null || l2 != null || dinm > 0)
        {
            summ = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + dinm;
            dinm = summ / 10;
            current.next = new ListNode(summ % 10);
            current = current.next;
            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        return result.next;
    }
}