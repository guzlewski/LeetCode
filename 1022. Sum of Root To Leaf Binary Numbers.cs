public class Solution
{
    private int DFS(TreeNode node, int value)
    {
        if (node == null)
        {
            return 0;
        }

        value = (value << 1) + node.val;

        if (node.left == null && node.right == null)
        {
            return value;
        }

        return DFS(node.left, value) + DFS(node.right, value);
    }

    public int SumRootToLeaf(TreeNode root)
    {
        return DFS(root, 0);
    }
}
