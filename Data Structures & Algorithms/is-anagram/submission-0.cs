public class Solution {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] valueOfS = s.ToCharArray();
            char[] valueOfT = t.ToCharArray();

            Array.Sort(valueOfS);
            Array.Sort(valueOfT);

            for (int i = 0; i < s.Length; i++)
            {
                if (valueOfS[i] != valueOfT[i])
                {
                    return false;
                }
            }

            return true;
        }

}
