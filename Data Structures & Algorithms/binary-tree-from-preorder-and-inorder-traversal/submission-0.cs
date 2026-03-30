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
    int preorderindex=0;
    Dictionary<int,int>inordermap;
    public TreeNode BuildTreeFromPreorder(int[] preorder,int left, int right)
    {
        if(left>right) return null;
        int rootval = preorder[preorderindex++];
        TreeNode root = new TreeNode(rootval);
        int inorderindex = inordermap[rootval];
        root.left = BuildTreeFromPreorder(preorder,left, inorderindex-1);
        root.right = BuildTreeFromPreorder(preorder,inorderindex+1,right);
        return root;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        inordermap = new Dictionary<int,int>();
        for(int i =0; i<inorder.Length;i++)
        {
            inordermap[inorder[i]]=i;
        }
        return BuildTreeFromPreorder(preorder,0,inorder.Length-1);
    }
}
