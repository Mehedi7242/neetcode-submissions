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
    public bool IsBalanced(TreeNode root) {
        return GetHeight(root) != -1;
    }
    private int GetHeight(TreeNode node) {
        if (node == null) {
            return 0;
        }
        int leftH = GetHeight(node.left);
        if (leftH == -1) return -1;
        
        int rightH = GetHeight(node.right);
        if (rightH == -1) return -1; 

        if (Math.Abs(leftH - rightH) > 1) {
            return -1; 
        }

        return Math.Max(leftH, rightH) + 1;
    }
}