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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;
        ListNode merged = lists[0];
        for(int i=1;i < lists.Length;i++)
        {
            merged = MergeList(merged, lists[i]);
        }
        return merged;
        
    }
    ListNode MergeList(ListNode list1,ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            ListNode res=dummy;
            ListNode curr1 = list1;
            ListNode curr2 = list2;
            while(curr1!=null && curr2!=null)
            {
                    if(curr1.val<curr2.val)
                    {
                        res.next=curr1;
                        curr1=curr1.next;
                    }
                    else
                    {
                        res.next = curr2;
                        curr2=curr2.next;
                    }
                    res=res.next;
            }  
            if(curr1!=null)
            {
                res.next=curr1;
            }
            else
            {
                res.next=curr2;
            }
            return dummy.next;
        }
}
