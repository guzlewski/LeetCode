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
public class Solution
{
    public int Depth(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }

        int left = Depth(node.left);

        if (left == -1)
        {
            return -1;
        }

        int right = Depth(node.right);

        if (right == -1 || Math.Abs(right - left) > 1)
        {
            return -1;
        }

        return Math.Max(left, right) + 1;
    }

    public bool IsBalanced(TreeNode root)
    {
        return Depth(root) != -1;
    }
}