public class Solution {
    public int Search(int[] nums, int target) {
        int left  = 0;
        int right = nums.Length-1;

        while(left <= right){
            if(target == nums[left]){
                return left;
            }
            if(target == nums[right]){
                return right;    
            } 
            left++;
            right--;
        }
        return -1;
    }
}
