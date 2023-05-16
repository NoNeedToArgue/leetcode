// Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

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
    public ListNode SwapPairs(ListNode head) {
        
        List<int> list = new();
        int count;

        while (head != null)
        {
            count = list.Count;
            if (count % 2 == 0)
            {
                list.Add(head.val);
            }
            else
            {
                list.Insert(count - 1, head.val);
            }
            head = head.next;
        }

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