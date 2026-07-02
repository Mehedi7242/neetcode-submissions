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
    private int ultimateMaxDiameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        ultimateMaxDiameter = 0;
        CalculateDepthAndTrackDiameter(root);
        return ultimateMaxDiameter;

    }
    public int CalculateDepthAndTrackDiameter(TreeNode root){
        if(root == null){
            return 0;
        }
        int leftD = CalculateDepthAndTrackDiameter(root.left);
        int rightD = CalculateDepthAndTrackDiameter(root.right);
        int currentDiameterThroughMe = leftD+rightD;
        ultimateMaxDiameter = Math.Max(ultimateMaxDiameter,currentDiameterThroughMe);

        return Math.Max(leftD,rightD)+1;

    }

}
