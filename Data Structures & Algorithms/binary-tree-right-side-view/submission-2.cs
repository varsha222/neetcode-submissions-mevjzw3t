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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if(root==null)
        {
            return res;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0)
        {
            int n= q.Count;
            for(int i=0;i<n;i++)
            {
                TreeNode node = q.Dequeue();
                if(i==n-1) res.Add(node.val);
                if(node.left!=null)
                {
                    q.Enqueue(node.left);
                }
                if(node.right!=null)
                {
                    q.Enqueue(node.right);
                }
            }
            

        }
        return res;
    }
}
