public class Solution {
    public bool IsPalindrome(string s)
    {
        string x = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
        char[] t = x.ToCharArray();
        char[] r = (char[])t.Clone();
        int left = 0;
        int right = t.Length - 1;

        while (left < right)
        {
            if (t[left] != t[right])
            {
                Console.WriteLine(t[left] + "" + t[right]);

                return false;
            }
            left++;
            right--;
           
        }return true;

    }
}
