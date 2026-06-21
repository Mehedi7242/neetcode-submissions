public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> window = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            // 1. If we find a duplicate in our current window of size k, we are done!
            if (window.Contains(nums[i])) {
                return true;
            }

            // 2. Add the current number to the window
            window.Add(nums[i]);

            // 3. Keep the window size at most k. 
            // If it exceeds k, evict the oldest element out of the window.
            if (window.Count > k) {
                window.Remove(nums[i - k]);
            }
        }

        return false;
    }
}