public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;int right=0;int res=0;
        HashSet<char> vis = new HashSet<char>();
        while(right<s.Length)
        {
            if(!vis.Contains(s[right]))
            {
                vis.Add(s[right]);
                res=Math.Max(res,right-left+1);
                right++;

            }
            else
            {
                vis.Remove(s[left]);
                left++;
            }
        }
        return res;
    }
}
