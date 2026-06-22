public class Solution {
    public int Search(int[] nums, int target) {

        for(int i = 0; i < nums.Length ;i++){
            int temp = nums[i];
            if(temp == target){
                return i;
            }
        }
        return -1;
    }
}
