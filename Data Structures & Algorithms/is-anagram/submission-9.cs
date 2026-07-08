public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        {
            return false;
        }
        int[] sfreq=new int[26];
        int[] tfreq=new int[26];

        for(int i=0;i<s.Length;i++)
        {
            sfreq[s[i]-'a']++;
            tfreq[t[i]-'a']++;
        }
        for(int i=0;i<26;i++)
        {
            if(sfreq[i]!=tfreq[i])
            {
                return false;
            }
        }
        return true;
            
    }
}
