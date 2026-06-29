public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);

        int expected = 1;

        foreach (int x in nums) {
            if (x < expected) {
                continue;
            } else if (x == expected) {
                expected++;
            } else  // x > expected
            {
                return expected;
            }
        }

        return expected;
    }
}