public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string word = strs[i];
            char[] eachWords = word.ToCharArray();
            Console.WriteLine(" ");

            Array.Sort(eachWords);

            string a = new string(eachWords);

            Console.WriteLine(a);

            if (!group.ContainsKey(a))
            {
                group[a] = new List<string>();

            }
            group[a].Add(word);

        }
        Console.WriteLine(group.Keys+" "+ group.Values);

        return group.Values.ToList();
    }
}
