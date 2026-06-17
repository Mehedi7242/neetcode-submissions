public class Solution {
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while(left<right)
        {
            char temp;
            temp = s[left];
            Console.WriteLine(temp);
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
            Console.WriteLine(temp);


        };

    }
}