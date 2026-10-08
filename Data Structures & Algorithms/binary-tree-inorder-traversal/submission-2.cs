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
    List<int>res=new List<int>();
    public List<int> InorderTraversal(TreeNode root) {
       Inorder(root);
       return res; 
    }
    void Inorder(TreeNode root)
    {
        if(root==null)
        {
            return;
        }
        Inorder(root.left);
        res.Add(root.val);
        Inorder(root.right);
        
    }
}