public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        {
            return false;
        }
        int[] freqs=new int[26];
        int[] freqt=new int[26];
        for(int i=0;i<s.Length;i++)
        {
            freqs[s[i]-'a']++;
            freqt[t[i]-'a']++;
        }
        for(int i=0;i<26;i++)
        {
            if(freqs[i]!=freqt[i])
            {
                return false;
            }
        }
        
        return true;
    }
}
