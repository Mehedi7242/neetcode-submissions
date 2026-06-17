public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookUp = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int remaining = target - nums[i];

            if (lookUp.ContainsKey(remaining)) {
                int firstIndex = lookUp[remaining];
                int secondIndex = i;

                Console.WriteLine(firstIndex + " " + secondIndex);
                return [firstIndex, secondIndex];
            }

            lookUp[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
