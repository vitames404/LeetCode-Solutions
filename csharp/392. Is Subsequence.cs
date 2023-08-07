public class Solution {
    public bool IsSubsequence(string s, string t) {

            string nextLetter = "";
            int count = 0;

            if(s.Length == t.Length)
            {
                if(s == t)
                {
                    return true;
                }
            }

            if(s == "")
            {
                return true;
            }

            for(int i = 0; i < t.Length; i++)
            {
                nextLetter = s[count].ToString();
                if(t[i].ToString() == nextLetter)
                {
                    count++;

                    if(count == s.Length)
                    {
                        return true;
                    }
                }
            }
            
            return false;
    }
}