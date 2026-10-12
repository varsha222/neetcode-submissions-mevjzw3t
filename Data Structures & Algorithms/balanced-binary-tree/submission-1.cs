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
       return heightBT(root)>=0;
    }
    public int heightBT(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        int lheight = heightBT(root.left);
        int rheight = heightBT(root.right);
        if(lheight==-1 || rheight==-1 ||  Math.Abs(lheight-rheight)>1)
        {
            return -1;
        }
        return Math.Max(lheight,rheight)+1;
    }
}
