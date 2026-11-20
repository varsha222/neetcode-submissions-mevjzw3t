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
    public bool IsBalanced(TreeNode root) {
        if(root==null)
        {
            return true;
        }
        int lh = heightBT(root.left);
        int rh = heightBT(root.right);
        if(Math.Abs(lh-rh)>1)
        {
            return false;
        }
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int heightBT(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        int lheight=heightBT(root.left);
        int rheight=heightBT(root.right);
        return Math.Max(lheight,rheight)+1;
    }
}
