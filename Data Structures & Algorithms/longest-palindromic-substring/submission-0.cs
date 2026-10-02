public class Solution {
    public string LongestPalindrome(string s) {
       if(string.IsNullOrEmpty(s))
       {
            return "";
       } 
       int start=0;
       int maxlen=1;
       for(int i=0;i<s.Length;i++)
       {
          int l1=ExpandAroundCentre(s,i,i);
          int l2=ExpandAroundCentre(s,i,i+1);
          int len = Math.Max(l1,l2);
          if(len>maxlen)
          {
            maxlen=len;
            start = i-(len-1)/2;
          }
       }
       return s.Substring(start,maxlen);
       
    }
    public int ExpandAroundCentre(string s, int left,int right)
    {
        while(left>=0 && right<s.Length && s[left]==s[right])
        {
            left--;
            right++;
        }
        return right-left-1;
    }
}
