public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0;
        Dictionary<char,int> freq = new Dictionary<char,int>();
        int res = 0;
        for(int r =0;r<s.Length;r++)
        {
            if(freq.ContainsKey(s[r]))
            {
                l = Math.Max(freq[s[r]]+1,l);
            }
            freq[s[r]]=r;
            res=Math.Max(res,r-l+1);
        }
        return res;
    }
}
