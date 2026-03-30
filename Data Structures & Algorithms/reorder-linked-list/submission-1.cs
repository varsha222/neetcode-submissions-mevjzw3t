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
    public void ReorderList(ListNode head) {
        if(head==null || head.next==null)
        {
            return;
        }
        ListNode slow=head;
        ListNode fast=head;
        while(fast != null && fast.next != null && fast.next.next != null)
        {
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode head1=slow.next;
        slow.next=null;
        ListNode prev=null;
        while(head1!=null)
        {
            ListNode Next=head1.next;
            head1.next=prev;
            prev=head1;
            head1=Next;
        }
        MergeRecursive(head,prev);

    }
    private void MergeRecursive(ListNode first, ListNode second)
    {
        if(second==null)
        {
            return;
        }
        ListNode temp1=first.next;
        ListNode temp2=second.next;
        first.next=second;
        second.next=temp1;
        MergeRecursive(temp1,temp2);
    }

}
