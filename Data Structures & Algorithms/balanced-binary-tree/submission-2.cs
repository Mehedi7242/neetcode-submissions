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
        return GetHeight(root) !=-1;
        }

    private int GetHeight(TreeNode node) {

        if(node == null){
            return 0;
        }
        int valueL = GetHeight(node.left);
        int valueR = GetHeight(node.right);
        if (valueL == -1 || valueR == -1) {
                    return -1;
                }

        if (Math.Abs(valueL - valueR) > 1) {
            return -1;
        }
        Console.WriteLine(valueL-valueR);
        return Math.Max(valueL,valueR)+1;        
  
    }
}



