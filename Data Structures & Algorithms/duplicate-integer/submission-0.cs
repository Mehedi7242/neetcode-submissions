public class Solution {
        public bool hasDuplicate(int[] nums)
        {
            HashSet<int> myHashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                myHashSet.Add(nums[i]);
            }
            if (myHashSet.Count < nums.Length)
            {
                Console.WriteLine(true);
                return true;
            }
            Console.WriteLine(false);

            return false;
        }
}