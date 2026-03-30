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
    public ListNode ReverseKGroup(ListNode head, int k) {
        int cnt=0;
        ListNode temp=head;
        while(cnt<k && temp!=null)
        {
            temp=temp.next;
            cnt++;
        }
        if (cnt < k) return head;
        ListNode prev = null;
        ListNode curr = head;
        for (int i = 0; i < k; i++) 
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        head.next = ReverseKGroup(curr, k);
        return prev;
    }
    
}
