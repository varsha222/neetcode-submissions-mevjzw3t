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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int length = 0;
        ListNode curr = head;

    // First pass: calculate the length of the list
        while (curr != null) {
            length++;
            curr = curr.next;
        }

    // If we need to remove the head
        if (n == length) {
            return head.next;
        }

    // Second pass: find the node before the one to remove
        curr = head;
        for (int i = 1; i < length - n; i++) {
            curr = curr.next;
        }

    // Remove the nth node from end
        curr.next = curr.next.next;

        return head;
    }
}
