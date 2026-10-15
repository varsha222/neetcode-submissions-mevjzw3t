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
    public bool IsValidBST(TreeNode root) {
        return Validate(root,long.MinValue,long.MaxValue);

    }
    public bool Validate(TreeNode root, long minv, long maxv)
    {
        if(root==null) return true;
        if(root.val<=minv || root.val>=maxv) return false;
        return Validate(root.left,minv,root.val) && Validate(root.right,root.val,maxv);
    }
}
