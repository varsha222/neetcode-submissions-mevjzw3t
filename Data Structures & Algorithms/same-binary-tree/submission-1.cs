/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Queue<TreeNode>temp1=new Queue<TreeNode>();
        Queue<TreeNode>temp2=new Queue<TreeNode>();
        temp1.Enqueue(p);
        temp2.Enqueue(q);
        while(temp1.Count>0 && temp2.Count>0)
        {
            TreeNode n1=temp1.Dequeue();
            TreeNode n2=temp2.Dequeue();
            if(n1 == null && n2 == null)
                continue;

            if(n1 == null || n2 == null)
                return false;
            if(n1.val!=n2.val)
            {
                return false;
            }
            
            temp1.Enqueue(n1.left);
            temp1.Enqueue(n1.right);

            temp2.Enqueue(n2.left);
            temp2.Enqueue(n2.right);

           

        }
        return temp1.Count==0 && temp2.Count==0;    
    }
    
}
