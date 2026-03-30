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
    int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
       maxGain(root);
       return maxSum; 
    }
    public int maxGain(TreeNode root)
    {
        if(root==null) return 0;
        int leftgain = Math.Max(maxGain(root.left),0);
        int rightgain = Math.Max(maxGain(root.right),0);
        int currentPathSum=root.val+leftgain+rightgain;
        maxSum = Math.Max(maxSum, currentPathSum);
        return root.val+Math.Max(leftgain,rightgain);
    }
}
