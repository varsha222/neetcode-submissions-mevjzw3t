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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        void postorder(TreeNode node)
        {
            if(node==null)
            {
                return;
            }
            postorder(node.left);
            postorder(node.right);
            res.Add(node.val);
        }
        postorder(root);
        return res;
    }
}