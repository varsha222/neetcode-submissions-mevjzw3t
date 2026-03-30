public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        int res = 0;
        Dictionary<char,int>mp = new Dictionary<char,int>();
        for(int r =0; r<s.Length;r++)
        {
            if (mp.ContainsKey(s[r]))
            {
                l = Math.Max(mp[s[r]]+1,l);
            }
            mp[s[r]]=r;
            res = Math.Max(res,r-l+1);
        }
        return res;
    }
}
