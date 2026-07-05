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
        // If our height calculator returns -1, it means an imbalance was found!
        return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode node) {
        // Base case: An empty node has a height of 0
        if (node == null) {
            return 0;
        }

        // 1. Get the height of the left subtree
        int leftH = GetHeight(node.left);
        if (leftH == -1) return -1; // If left is unbalanced, pass the error up!

        // 2. Get the height of the right subtree
        int rightH = GetHeight(node.right);
        if (rightH == -1) return -1; // If right is unbalanced, pass the error up!

        // 3. Check if the current node violates the balance rule
        if (Math.Abs(leftH - rightH) > 1) {
            return -1; // Imbalance found! Return our error flag.
        }

        // 4. If perfectly balanced, return the actual height to the parent
        return Math.Max(leftH, rightH) + 1;
    }
}