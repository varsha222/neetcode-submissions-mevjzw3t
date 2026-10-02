public class Solution {
    public int CountSubstrings(string s) {
        int cnt=0;
        for(int i=0;i<s.Length;i++)
        {
            cnt+= Expand(s,i,i);
            cnt+= Expand(s,i,i+1);

        }
        return cnt;
        
    }
    public int Expand(string s, int left, int right)
    {
        int cnt=0;
        while(left>=0 && right<s.Length && s[left]==s[right])
        {
            cnt++;
            left--;
            right++;
            
        }
        return cnt;
    }
}
