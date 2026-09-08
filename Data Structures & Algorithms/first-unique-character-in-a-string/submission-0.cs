public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int>freq = new Dictionary<char,int>();
        foreach(char ch in s)
        {
            if(freq.ContainsKey(ch))
            {
                freq[ch]++;
            }
            else{
                freq[ch]=1;
            }
        }
        for(int i=0;i<s.Length;i++)
        {
            if(freq.ContainsKey(s[i]) && freq[s[i]]==1)
            {
                return i;
            }
        }

        return -1;
    }
}