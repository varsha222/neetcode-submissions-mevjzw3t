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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
         if (head == null || left == right) return head;

    ListNode dummy = new ListNode(0);
    dummy.next = head;

    // Step 1: Reach node before `left`
    ListNode pre_left = dummy;
    for (int i = 1; i < left; i++) {
        pre_left = pre_left.next;
    }

    // Step 2: Start reversing from `left` to `right`
    ListNode curr = pre_left.next;
    ListNode prev = null;
    for (int i = 0; i <= right - left; i++) {
        ListNode next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }

    // Step 3: Reconnect the reversed sublist
    pre_left.next.next = curr;  // tail of reversed sublist points to node after `right`
    pre_left.next = prev;       // node before `left` points to new head of reversed sublist

    return dummy.next;



    }
}