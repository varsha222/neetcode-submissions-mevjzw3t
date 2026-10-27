public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++)
        {
            map[inorder[i]] = i;
        }

        return SplitTree(preorder, 0, 0, inorder.Length - 1, map);
    }

    private TreeNode SplitTree(
        int[] preorder,
        int index,
        int left,
        int right,
        Dictionary<int, int> map)
    {
        if (left > right)
            return null;

        TreeNode root = new TreeNode(preorder[index]);

        int mid = map[preorder[index]];

        if (mid > left)
        {
            root.left = SplitTree(
                preorder,
                index + 1,
                left,
                mid - 1,
                map);
        }

        if (mid < right)
        {
            root.right = SplitTree(
                preorder,
                index + (mid - left) + 1,
                mid + 1,
                right,
                map);
        }

        return root;
    }
}