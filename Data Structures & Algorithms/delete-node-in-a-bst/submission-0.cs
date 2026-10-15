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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root==null)
        {
            return root;
        }
        if(key<root.val)
        {
            root.left=DeleteNode(root.left,key);
        }
        else if(key>root.val)
        {
            root.right=DeleteNode(root.right,key);
        }
        else
        {
            if(root.left==null)
            {
                return root.right;
            }
            else if(root.right==null)
            {
                return root.left;
            }
            else
            {
                if(root.left==null)
                {
                    return  root.right;
                }
                else if(root.right==null)
                {
                    return root.left;
                }
                root.val=Minvalue(root.right);
                root.right=DeleteNode(root.right,root.val);
                
            }
            
        }
        return  root;
    }
                                                                                 
    public int Minvalue(TreeNode root)
    {
        int minv = root.val;
        while(root.left!=null)
        {
            minv=root.left.val;
            root=root.left;
        }
        return minv;
    }
}