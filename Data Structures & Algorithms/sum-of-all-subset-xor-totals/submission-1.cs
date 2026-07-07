public class Solution {
    public int SubsetXORSum(int[] nums) 
    {
        if (nums.Length == 0) return 0;

        int bitwiseOrTotal = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            bitwiseOrTotal |= nums[i];
        }
        
        return bitwiseOrTotal << (nums.Length - 1);
    }
}