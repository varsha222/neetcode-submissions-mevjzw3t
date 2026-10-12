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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root==null)
        {
            return 0;
        }
        int ll = DiameterOfBinaryTree(root.left);
        int rl =DiameterOfBinaryTree(root.right);
        int lheight = heightBT(root.left);
        int rheight = heightBT(root.right);
        return Math.Max(lheight+rheight,Math.Max(ll,rl));
    }
    public int heightBT(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        int lheight = heightBT(root.left);
        int rheight = heightBT(root.right);
        return(Math.Max(lheight,rheight)+1);
    }
}
