// You are given the head of a linked list, and an integer k.

// Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).

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
    public ListNode SwapNodes(ListNode head, int k) {
        
        List<int> list = new();
        
        while(head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        int temp = list[k - 1];
        list[k - 1] = list[^k];
        list[^k] = temp;

        var tail = new ListNode();
        var result = tail;

        foreach (int i in list)
        {
            var node = new ListNode(i);

            tail.next = node;

            tail = node;
        }

        return result.next;
    }
}