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
    public int GoodNodes(TreeNode root) {
        return helper(root,int.MinValue);
    }
    private int helper(TreeNode root,int curmax)
    {
        if(root==null)
        {
            return 0;
        }
        int rootans=0;
        if(root.val>=curmax)
        {
            rootans=1;
            curmax=root.val;

        }
        int lans = helper(root.left,curmax);
        int rans = helper(root.right,curmax);
        return lans+rans+rootans;
    }
}
