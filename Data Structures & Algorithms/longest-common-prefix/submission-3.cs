public class Solution {
    public string LongestCommonPrefix(string[] strs)     {
        string prefix = string.Empty;
        for (int i = 0; i < strs[0].Length; i++)
        {
            char currentLetter = strs[0][i];

            for (int j = 1;j<strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != currentLetter)
                {
                    return prefix;
                }
            }
            prefix = prefix + currentLetter;

        };
        return prefix;
    }
}