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

    List<int> res = new List<int>();
    public List<int> PreorderTraversal(TreeNode root) {
        
        preorder(root);
        return res;
        
    }
    public void preorder(TreeNode root)
    {
        if(root==null)
        {
            return;
        }
        res.Add(root.val);
        preorder(root.left);
        preorder(root.right);
    }
}