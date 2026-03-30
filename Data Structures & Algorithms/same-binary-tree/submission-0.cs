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
        if(p==null && q==null) return true;
        if(p==null || q==null) return false;
        Queue<TreeNode> temp1= new Queue<TreeNode>();
        Queue<TreeNode> temp2= new Queue<TreeNode>();
        temp1.Enqueue(p);
        temp2.Enqueue(q);
        while(temp1.Count>0 && temp2.Count>0)
        {
            TreeNode n1=temp1.Dequeue();
            TreeNode n2=temp2.Dequeue();
            if(n1.val!=n2.val) return false;
            if(n1.left!=null && n2.left!=null)
            {
                if(n1.left.val!=n2.left.val) return false;
                else
                {
                    temp1.Enqueue(n1.left);
                    temp2.Enqueue(n2.left);
                }
            }
            else if (n1.left != null || n2.left != null)
                {
                    return false;
                }
            
            if(n1.right!=null && n2.right!=null)
            {
                if(n1.right.val!=n2.right.val) return false;
                else
                {
                    temp1.Enqueue(n1.right);
                    temp2.Enqueue(n2.right);
                }

            }
            else if (n1.right != null || n2.right != null)
                {
                    return false;
                }
            
        }
        return true;


    }
}
