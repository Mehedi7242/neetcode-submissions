public class Solution {
public string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

    if (strs.Length == 1)
        return strs[0];

    string prefix = strs[0];

    for (int i = 1; i < strs.Length; i++)
    {
       while (!strs[i].StartsWith(prefix, StringComparison.Ordinal))
        {
            prefix = prefix[..^1]; 

            if (string.IsNullOrEmpty(prefix))
                return "";
        }
    }

    return prefix;
}
}