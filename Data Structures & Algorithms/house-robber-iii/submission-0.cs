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
    public int Rob(TreeNode root) {
        int[] options = travel(root);
        return Math.Max(options[0],options[1]); 
    }
    private int[] travel(TreeNode root)
    {
        if(root==null)
        {
            return new int[2];
        }

        int[] leftnoderoot = travel(root.left);
        int[] rightnoderoot = travel(root.right);
        int[] options = new int[2];

        options[0] = root.val+leftnoderoot[1]+rightnoderoot[1];
        options[1] = Math.Max(leftnoderoot[0],leftnoderoot[1])+Math.Max(rightnoderoot[0],rightnoderoot[1]);
        return options;
    }
}