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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        List<int?> listP = new List<int?>();
        List<int?> listQ = new List<int?>();
CheckNode(p, listP);
        CheckNode(q, listQ);
        if(listP.Count!= listQ.Count){
            return false;
        }

        for(int i = 0; i < listP.Count; i++){
            if(listP[i] != listQ[i]){
                return false;
            }
        }return true;

    }
    public void CheckNode(TreeNode node, List<int?> result){
        if(node == null){
            result.Add(null);
            return;
        }
        result.Add(node.val);
        CheckNode(node.left,result);
        CheckNode(node.right,result);
    }
}
