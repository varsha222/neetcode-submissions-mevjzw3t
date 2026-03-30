public class Solution {
    public bool IsAnagram(string s, string t) {
        int n1 = s.Length;
        int n2 = t.Length;
        if(n1!=n2)
        {
            return false;
        }
        int[] freq = new int[26];
        foreach(char ch in s)
        {
            freq[ch-'a']++;
        }
        foreach(char ch in t)
        {
            freq[ch-'a']--;
        }
        foreach(int i in freq)
        {
            if(i!=0)
            {
                return false;
            }
        }
        
        return true;
        

    }
}
