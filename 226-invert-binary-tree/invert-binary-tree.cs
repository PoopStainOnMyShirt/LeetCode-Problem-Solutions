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
    private List<int> root = new List<int>();
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)return root;
        TreeNode left_inverted = InvertTree(root.left);
        TreeNode right_inverted = InvertTree(root.right);
        root.left = right_inverted;
        root.right = left_inverted;
        return root;
    }
}